using core.Events;
using MassTransit;

namespace notification_service.Consumers;

public class BookNotificationEventConsumer : IConsumer<IBookEvent>
{
    public Task Consume(ConsumeContext<IBookEvent> context)
    {
        Console.WriteLine($"{context.Message.Name} isimli kitap yayınlanarak müşteriler bilgilendirilmiştir.");
        return Task.CompletedTask;
    }
}