namespace Ordering.Domain.Events;

public record class OrderUpdatedEvent(Order Order) : IDomainEvent;
