using core.Events;
using MassTransit;

namespace multibus_service.Consumers;
// kuyruk ismi MultiBusOneEvent diye oluşuyor.
public class MultiBusOneEventConsumer : IConsumer<IMultibusEvent>
{
    public Task Consume(ConsumeContext<IMultibusEvent> context)
    {
        Console.WriteLine($"#11111# {context.Message.Name} isimli kitap Multibus one ile iletildi.");
        return Task.CompletedTask;
    }
}