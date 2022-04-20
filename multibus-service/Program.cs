using core.Events;
using MassTransit;
using multibus_service;
using multibus_service.Consumers;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddMassTransit(x =>
        {
            x.AddConsumer<MultiBusOneEventConsumer>();
            x.AddRequestClient<IMultibusEvent>();
            x.UsingRabbitMq((context, cfg) =>
            {
                cfg.Host("localhost", e =>
                {
                    e.Username("guest");
                    e.Password("guest");
                });
                cfg.ConfigureEndpoints(context);
            });
        });
        /*********************Two******************************/
        services.AddMassTransit<ISecondBus>(x =>
        {
            x.AddConsumer<MultiBusTwoEventConsumer>();
            x.AddRequestClient<IMultibusEvent>();
            x.UsingRabbitMq((context, cfg) =>
            {
                cfg.Host("localhost", e =>
                {
                    e.Username("guest");
                    e.Password("guest");
                });
                cfg.ConfigureEndpoints(context);
            });
        });
        /********************Threee*******************************/
        services.AddMassTransit<IThirdBus>(x =>
        {
            x.AddConsumer<MultiBusThreeEventConsumer>();
            x.AddRequestClient<IMultibusEvent>();
            x.UsingRabbitMq((context, cfg) =>
            {
                cfg.Host("localhost", e =>
                {
                    e.Username("guest");
                    e.Password("guest");
                });
                cfg.ConfigureEndpoints(context);
            });
        });
        /********************Four*******************************/
        services.AddMassTransit<IFourthBus>(x =>
        {
            x.AddConsumer<MultiBusFourEventConsumer>();
            x.AddRequestClient<IMultibusEvent>();
            x.UsingRabbitMq((context, cfg) =>
            {
                cfg.Host("localhost", e =>
                {
                    e.Username("guest");
                    e.Password("guest");
                });
                cfg.ConfigureEndpoints(context);
            });
        });
        
    })
    .Build();

await host.RunAsync();