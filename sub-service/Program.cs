using core;
using MassTransit;
using sub_service.Consumers;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        //services.AddHostedService<Worker>();
        var bus = BusConfigurator.ConfigureBus(factory =>
        {
            factory.ReceiveEndpoint(RabbitMqConstants.SubServiceQueue, endpoint =>
            {
                endpoint.Consumer<BookRegistrationCommandConsumer>();
            });
        });
        bus.Start();

    })
    .Build();

await host.RunAsync();