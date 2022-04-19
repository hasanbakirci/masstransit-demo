using core.Commands;
using MassTransit;

namespace core.Consumers;

public class BookRegistrationCommandConsumer : IConsumer<IBookRegistrationCommand>
{
    public Task Consume(ConsumeContext<IBookRegistrationCommand> context)
    {
        Console.WriteLine("*********************");
        Console.WriteLine($"{context.Message.Name} isimli kitap yaratılıyor..");
        Console.WriteLine("*********************");
        return Task.CompletedTask;
    }
}