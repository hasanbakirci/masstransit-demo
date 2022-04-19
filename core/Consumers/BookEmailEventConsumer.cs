using core.Events;
using MassTransit;

namespace core.Consumers;

public class BookEmailEventConsumer : IConsumer<IBookEvent>
{
    public Task Consume(ConsumeContext<IBookEvent> context)
    {
        Console.WriteLine("*********************");
        Console.WriteLine($"{context.Message.Name} isimli kitap için mail gönderildi.");
        Console.WriteLine("*********************");
        return Task.CompletedTask;
    }
}