namespace Microservices.Core.Events.Interfaces;

public interface IDomainEvent
{
    DateTime OccurredOn { get; }
}
