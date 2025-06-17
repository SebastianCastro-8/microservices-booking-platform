namespace Microservices.Core.Messaging.Interfaces;

public interface IEventPublisher
{
    Task PublishAsync<TEvent>(TEvent @event, string topic, CancellationToken cancellationToken = default)
       where TEvent : class;
}
