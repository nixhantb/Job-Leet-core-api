using JobLeet.WebApi.JobLeet.Core.Services.MessageBroker.Helpers;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;


namespace JobLeet.WebApi.JobLeet.Core.Services.MessageBroker.Consumer
{

    public class RabbitMQConsumerService : BackgroundService
    {

        private readonly RabbitMQServiceSetup _rabbitMQServiceSetup;
        private readonly ILogger<RabbitMQConsumerService> _logger;
        private readonly IModel _channel;

        public RabbitMQConsumerService(RabbitMQServiceSetup rabbitMQServiceSetup, ILogger<RabbitMQConsumerService> logger)
        {
            _rabbitMQServiceSetup = rabbitMQServiceSetup;
            _logger = logger;
            _channel = _rabbitMQServiceSetup.GetChannel();
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            stoppingToken.ThrowIfCancellationRequested();

            var consumer = new EventingBasicConsumer(_channel);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                _logger.LogInformation("Received message: {message}", message);

            };

            _channel.BasicConsume(queue: "jobleetServerQueue", autoAck: true, consumer: consumer);
            return Task.CompletedTask;
        }


        public override void Dispose()
        {
            _rabbitMQServiceSetup.Dispose();
            base.Dispose();
        }
    }
}