using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc1.Receiver.Domain.Events
{
    public record StartSyncEvent(Guid SyncId, DateTime DateStarted);
    
}
