namespace core.Events;

public interface IBookEvent
{
    public int Id { get; set; }
    public string Name { get; set; }
}