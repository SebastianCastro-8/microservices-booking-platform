namespace Microservices.Core.Messaging.Settings;

public class RabbitMQSettings
{
    public string HostName { get; set; } = string.Empty;
    public string VirtualHost { get; set; } = "/";
    public string UserName { get; set; } = "guest";
    public string Password { get; set; } = "guest";
    public int Port { get; set; } = 5672;
    public string Exchange { get; set; } = "default_exchange";
}
