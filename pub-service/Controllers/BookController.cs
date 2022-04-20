using core;
using core.Commands;
using core.Events;
using MassTransit;
using Microsoft.AspNetCore.Mvc;

namespace pub_service.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
    private readonly IBus _bus;
    public BookController()
    {
        _bus = BusConfigurator.ConfigureBus();
    }

    [HttpPost("/publish")]
    public async Task<IActionResult> PostBook([FromBody] CreateBookRequest request)
    {
        await _bus.Publish<IBookEvent>(new {request.Id,request.Name});
        return Ok($"{request.Name} : publish olarak gönderildi.");
    }
    
    [HttpPost("/send")]
    public async Task<IActionResult> SendBook([FromBody] CreateBookRequest request)
    {
        var sendToUri = new Uri($"queue:{RabbitMqConstants.SubServiceQueue}");
        var endPoint = await _bus.GetSendEndpoint(sendToUri);
        await endPoint.Send<IBookRegistrationCommand>(new {request.Id, request.Name});
        return Ok($"{request.Name} : send olarak gönderildi.");
    }
    
    [HttpPost("/multibus")]
    public async Task<IActionResult> MultibusBook([FromBody] CreateBookRequest request)
    {
        await _bus.Publish<IMultibusEvent>(new {request.Id,request.Name});
        return Ok($"{request.Name} : publish multibus olarak gönderildi.");
    }
}