using core.Commands;
using MassTransit;

namespace sub_service.Consumers;

public class BookRegistrationCommandConsumer : IConsumer<IBookRegistrationCommand>
{
    public Task Consume(ConsumeContext<IBookRegistrationCommand> context)
    {
        Console.WriteLine($"{context.Message.Name} isimli kitap yaratılıyor..");
        return Task.CompletedTask;
    }
}