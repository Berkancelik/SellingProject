using EventBus.Base.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EventBus.Base.Abstraction
{
    // Subscribe Event Bus 
    public  interface IEventBus
    {
        void Publish(IntegrationEvent @event);

        void Subscribe<T, TH>() where T:IntegrationEvent where TH:IIntegrationEventHandler<T>;

        void UnSubscribe<T, TH>() where T : IntegrationEvent where TH:IIntegrationEventHandler<T>;
    }
}
