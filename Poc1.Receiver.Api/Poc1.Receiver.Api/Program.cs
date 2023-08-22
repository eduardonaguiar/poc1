using Poc1.Receiver.Application.Interfaces;
using Poc1.Receiver.Domain.Events;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddSingleton<IEventProducer<StartSyncEvent>>(sp =>
//{
//    var config = new ProducerConfig { BootstrapServers = "localhost:9092" }; 
//    return new KafkaEventProducer<StartSyncEvent>("StartSync", config);
//});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
