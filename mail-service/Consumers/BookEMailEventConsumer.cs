using core.Events;
using MassTransit;

namespace mail_service.Consumers;

public class BookEMailEventConsumer : IConsumer<IBookEvent>
{
    public Task Consume(ConsumeContext<IBookEvent> context)
    {
        Console.WriteLine($"{context.Message.Name} isimli kitap için mail gönderildi.");
        return Task.CompletedTask;
    }
}