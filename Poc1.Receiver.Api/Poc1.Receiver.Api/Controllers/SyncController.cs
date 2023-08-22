using Microsoft.AspNetCore.Mvc;
using Poc1.Receiver.Domain.Events;
using Poc1.Receiver.Domain.Interfaces;

namespace Poc1.Receiver.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SyncController : ControllerBase
    {
        private readonly IEventProducer<StartSyncEvent> _eventProducer;

        public SyncController(IEventProducer<StartSyncEvent> eventProducer)
        {
            _eventProducer = eventProducer;
        }

        //[HttpPost(Name = "StartSync")]
        //public void StartSync()
        //{
        //    //var syncEvent = new StartSyncEvent(Guid.NewGuid(), DateTime.UtcNow);
        //    //await _eventProducer.ProduceAsync(syncEvent);
        //    return Ok();
        //}
    }
}