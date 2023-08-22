namespace Poc1.Receiver.Application.Interfaces
{
    public interface IEventProducer<TEvent>
    {
        Task ProduceAsync(TEvent domainEvent);
    }
}
