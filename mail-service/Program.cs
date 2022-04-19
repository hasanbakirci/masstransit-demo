using core;
using core.Consumers;
using MassTransit;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        //services.AddHostedService<Worker>();
        var bus = BusConfigurator.ConfigureBus(factory =>
        {
            factory.ReceiveEndpoint(RabbitMqConstants.EmailServiceQueue, endpoint =>
            {
                endpoint.Consumer<BookEmailEventConsumer>();
            });
        });
        bus.Start();
    })
    .Build();

await host.RunAsync();