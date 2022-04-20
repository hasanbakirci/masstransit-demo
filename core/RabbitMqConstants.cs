namespace core;

public static class RabbitMqConstants
{
    public const string RabbitMqUri = "localhost";
    public const string Username = "guest";
    public const string Password = "guest";
    public const string SubServiceQueue = "sub.service";
    public const string NotificationServiceQueue = "notification.service";
    public const string EmailServiceQueue = "email.service";
    
    // multibus'ta kuyruk isimlerine gerek yok. Multibus/Consumers isimlerine göre kuyruk oluşturuyor.
    // public const string MultiBusOneQueue = "multibusone.service";
    // public const string MultiBusTwoQueue = "multibustwo.service";
}