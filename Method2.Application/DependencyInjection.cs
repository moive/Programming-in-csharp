using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2.Application
{
    public interface IMessageSender
    {
        void SendMessage(string message);
    }

    public class DependencyInjection
    {
        public DependencyInjection()
        {
            var smsSender = new SendMinMessage();
            var messageSender = new MessageSender(smsSender);
            messageSender.SendMessage("This message is cool");
        }
    }

    public class MessageSender
    {
        public MessageSender(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        private IMessageSender _messageSender;

        public void SendMessage(string message)
        {
            _messageSender.SendMessage(message);
        }
    }

    class SendMinMessage : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Sending message");
        }
    }

    class SendEmail : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Sending email");
        }
    }
}
