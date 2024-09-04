using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerTest
{
    public delegate void CustomEventHandler(object e, CustomEventArgs args);
    public class Publisher
    {
        public event CustomEventHandler CustomEvent;

        protected virtual void OnMyEvent(CustomEventArgs e)
        {
            CustomEvent?.Invoke(this, e);
        }

        public void Trigger(string message)
        {
            OnMyEvent(new CustomEventArgs(message));
        }
    }
}
