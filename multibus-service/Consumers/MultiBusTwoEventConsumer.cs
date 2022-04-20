using core.Events;
using MassTransit;

namespace multibus_service.Consumers;
// kuyruk ismi MultiBusTwoEvent diye oluşuyor.
public class MultiBusTwoEventConsumer : IConsumer<IMultibusEvent>
{
    public Task Consume(ConsumeContext<IMultibusEvent> context)
    {
        Console.WriteLine($"#22222# {context.Message.Name} isimli kitap Multibus two ile iletildi.");
        return Task.CompletedTask;
    }
}