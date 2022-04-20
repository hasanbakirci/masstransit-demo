using core.Events;
using MassTransit;

namespace multibus_service.Consumers;

public class MultiBusThreeEventConsumer : IConsumer<IMultibusEvent>
{
    public Task Consume(ConsumeContext<IMultibusEvent> context)
    {
        Console.WriteLine($"#33333# {context.Message.Name} isimli kitap Multibus three ile iletildi.");
        return Task.CompletedTask;
    }
}