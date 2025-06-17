using Microservices.Core.Events.Interfaces;

namespace Microservices.Core.Events.Implementations;

public abstract class BaseIntegrationEvent : IIntegrationEvent
{
    public Guid Id { get; } = Guid.NewGuid();
    public DateTime OccurredOn { get; } = DateTime.UtcNow;
}
