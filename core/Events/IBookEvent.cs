﻿namespace core.Events;
// exchange ismi olarak core.Events:IBookEvent oluşturur.
public interface IBookEvent
{
    public int Id { get; set; }
    public string Name { get; set; }
}