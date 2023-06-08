using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Base
{
    /// <summary>
    /// The integration event type sent to us is kept here. then the related methd is called by reaching its handle method via this type
    /// </summary>
    public class SubscriptionInfo
    {
        public Type HandlerType { get;}

        public SubscriptionInfo(Type handlerType)
        {
            HandlerType = handlerType?? throw new ArgumentNullException(nameof(handlerType));
        }

        public static SubscriptionInfo Typed(Type handlerType)
        {
            return new SubscriptionInfo(handlerType);
        }
    }
}
