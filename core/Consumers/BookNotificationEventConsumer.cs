using core.Events;
using MassTransit;

namespace core.Consumers;

public class BookNotificationEventConsumer : IConsumer<IBookEvent>
{
    public Task Consume(ConsumeContext<IBookEvent> context)
    {
        Console.WriteLine("*********************");
        Console.WriteLine($"{context.Message.Name} isimli kitap yayınlanarak müşteriler bilgilendirilmiştir.");
        Console.WriteLine("*********************");
        return Task.CompletedTask;
    }
}