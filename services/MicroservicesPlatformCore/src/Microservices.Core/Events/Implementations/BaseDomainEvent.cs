using Microservices.Core.Events.Interfaces;

namespace Microservices.Core.Events.Implementations;

public abstract class BaseDomainEvent : IDomainEvent
{
    public DateTime OccurredOn { get; } = DateTime.UtcNow;
}

