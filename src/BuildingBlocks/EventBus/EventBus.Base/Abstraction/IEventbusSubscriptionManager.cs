using EventBus.Base.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Base.Abstraction
{
     /// <summary>
    ///  This manager will decide if any subscribe
    /// </summary>
    public interface IEventbusSubscriptionManager
    {
        bool IsEmpty { get; }

        /// <summary>
        /// When the event is removed, this event is triggered when the inside event is created and the unscribe method that comes to us from outside works.
        /// </summary>
        event EventHandler<string> OnEventRemoved;

        void AddSubscription<T, TH>() where TH: IIntegrationEventHandler<T> where T : IntegrationEvent;

        /// <summary>
        /// When an event is sent to us from the outside, it is the method that will detect whether we have already subscribed it or not.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// 
        bool HasSubscriptionForEvent<T>() where T : IntegrationEvent;
        bool HasSubscriptionForEvent(string eventName);

        /// <summary>
        /// When the event arrives, it sends its type.
        /// </summary>
        /// <param name="eventName"></param>
        /// <returns></returns>
        Type GetEventTypeByName(string eventName);

        /// <summary>
        /// Deletes the list
        /// </summary>
        void Clear();
        
        IEnumerable<SubscriptionInfo> GetHandlerForEvent<T>() where T :IntegrationEvent;
        IEnumerable<SubscriptionInfo> GetHandlerForEvent(string eventName);

        //A key for integration events
        string GetEventKey<T>();
    }
}
