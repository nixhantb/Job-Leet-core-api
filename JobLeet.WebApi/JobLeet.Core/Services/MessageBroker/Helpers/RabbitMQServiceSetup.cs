using RabbitMQ.Client;

namespace JobLeet.WebApi.JobLeet.Core.Services.MessageBroker.Helpers
{
    public class RabbitMQServiceSetup
    {
        private readonly IConfiguration _configuration;
        private IConnection _connection;
        private IModel _channel;

        public RabbitMQServiceSetup(IConfiguration configuration)
        {
            _configuration = configuration;
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
