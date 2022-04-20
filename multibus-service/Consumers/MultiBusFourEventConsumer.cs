using core.Events;
using MassTransit;

namespace multibus_service.Consumers;

public class MultiBusFourEventConsumer : IConsumer<IMultibusEvent>
{
    public Task Consume(ConsumeContext<IMultibusEvent> context)
    {
        Console.WriteLine($"#44444# {context.Message.Name} isimli kitap Multibus four ile iletildi.");
        return Task.CompletedTask;
    }
}