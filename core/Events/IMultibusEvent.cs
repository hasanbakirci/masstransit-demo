namespace core.Events;
// exchange ismi olarak core.Events:IMultiBusEvent oluşturur.
public interface IMultibusEvent
{
    public int Id { get; set; }
    public string Name { get; set; }
}