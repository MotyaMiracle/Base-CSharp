namespace TrainingBase
{
    public class Program
    {
        static void Main(string[] args)
        {
            Messenger<Message> tg = new Messenger<Message>();
            tg.SendMessage(new Message("Hello World"));
            tg.SendMessage(new EmailMessage("Bye World"));
            //SendMessage<EmailMessage>(new EmailMessage("Bye World")); // Можно указать явно
            Console.WriteLine();

            Messenger<EmailMessage> outlook = new Messenger<EmailMessage>();
            outlook.SendMessage(new EmailMessage("123456"));
            Console.WriteLine();

            Messenger2<Message, Person> telegram = new Messenger2<Message, Person>();
            Person tom = new Person("Tom");
            Person sam = new Person("Sam");
            Message hello = new Message("Hello, Sam!");
            telegram.SendMessage(tom, sam, hello);
        }
        
    }
}