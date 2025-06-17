namespace Microservices.Core.Events.Interfaces;

public interface IIntegrationEvent
{
    Guid Id { get; }
    DateTime OccurredOn { get; }
}
