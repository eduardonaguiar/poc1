using Confluent.Kafka;
using Poc1.Receiver.Domain.Interfaces;
using System.Text.Json;

public class KafkaEventProducer<TEvent> : IEventProducer<TEvent>
{
    private readonly string _topic;
    private readonly IProducer<Null, string> _producer;

    public KafkaEventProducer(string topic, ProducerConfig config)
    {
        _topic = topic;
        _producer = new ProducerBuilder<Null, string>(config).Build();
    }

    public async Task ProduceAsync(TEvent domainEvent)
    {
        var message = new Message<Null, string> { Value = JsonSerializer.Serialize(domainEvent) };
        await _producer.ProduceAsync(_topic, message);
    }
}