using RabbitMQ.Client;

namespace JobLeet.WebApi.JobLeet.Core.Services.MessageBroker.Helpers
{
    public class RabbitMQServiceSetup
    {
        private readonly IConfiguration _configuration;
        private IConnection _connection;
        private IModel _channel;
        private ILogger<RabbitMQServiceSetup> _logger;

        public RabbitMQServiceSetup(IConfiguration configuration, ILogger<RabbitMQServiceSetup> logger)
        {
            _configuration = configuration;
            _logger = logger;
            SetupRabbitMQ();
        }

        public IConnection GetConnection()
        {
            return _connection;
        }

        public IModel GetChannel()
        {
            return _channel;
        }

        private void SetupRabbitMQ()
        {
            var factory = new ConnectionFactory
            {
                HostName = _configuration["RabbitMQ:HostName"],
                UserName = _configuration["RabbitMQ:UserName"],
                Password = _configuration["RabbitMQ:Password"]
            };

            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();
            _logger.LogInformation("Connection to rabbitMQ is successful"+_channel);
            // Declare exchange (optional if it doesn't exist)
            _channel.ExchangeDeclare(exchange: "messages", type: ExchangeType.Fanout);

            // Declare queue
            _channel.QueueDeclare(queue: "jobleetServerQueue",
                                 durable: true,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);
            // Bind queue to exchange
            _channel.QueueBind(queue: "jobleetServerQueue",
                                    exchange: "messages",
                                    routingKey: "");
        }
         public void Dispose()
        {
            _channel?.Close();
            _connection?.Close();
        }
    }
}
