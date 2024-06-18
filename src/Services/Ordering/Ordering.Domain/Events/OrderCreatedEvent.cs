namespace Ordering.Domain.Events;

public record class OrderCreatedEvent(Order Order) : IDomainEvent;
