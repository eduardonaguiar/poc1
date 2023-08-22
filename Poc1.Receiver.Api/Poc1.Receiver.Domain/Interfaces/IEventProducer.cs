namespace Poc1.Receiver.Domain.Interfaces
{
    public interface IEventProducer<TEvent>
    {
        Task ProduceAsync(TEvent domainEvent);
    }
}
