using core;
using core.Consumers;
using MassTransit;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        //services.AddHostedService<Worker>();
        var bus = BusConfigurator.ConfigureBus(factory =>
        {
            factory.ReceiveEndpoint(RabbitMqConstants.NotificationServiceQueue, endpoint =>
            {
                endpoint.Consumer<BookNotificationEventConsumer>();
            });
        });
        bus.Start();
        
    })
    .Build();

await host.RunAsync();