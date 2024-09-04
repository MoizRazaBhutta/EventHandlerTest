namespace EventHandlerTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscriber1 subscriber1 = new Subscriber1();
            Subscriber2 subscriber2 = new Subscriber2();


            publisher.CustomEvent += subscriber1.CustomHandler;
            publisher.CustomEvent += subscriber2.CustomHandler;


            // Trigger the event
            publisher.Trigger("Broadcast the message to all");
        }
    }
}
