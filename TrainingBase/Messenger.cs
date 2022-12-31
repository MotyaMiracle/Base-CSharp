using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingBase
{
    public class Messenger<T> where T : Message
    {
        public void SendMessage(T message)
        {
            Console.WriteLine($"Отправляется сообщение: {message.Text}");
        }
    }
}
