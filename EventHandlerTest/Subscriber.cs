using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerTest
{
    public class Subscriber1
    {
        public void CustomHandler(object sender, CustomEventArgs e)
        {
            Console.WriteLine($"Message received by Subscriber 1: {e.Message}");
        }
    }
    public class Subscriber2
    {
        public void CustomHandler(object sender, CustomEventArgs e)
        {
            Console.WriteLine($"Message received by Subscriber 2: {e.Message}");
        }
    }
}
