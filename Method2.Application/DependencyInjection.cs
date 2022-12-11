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
            var messageSenderDependency = FactoryMessageSender.Factory("email");
            var messageSender = new MessageSender(messageSenderDependency);
            messageSender.SendMessage("This message is cool");
        }
    }

    public static class FactoryMessageSender
    {
        public static IMessageSender Factory(string parameter)
        {
            if (parameter == "sms")
            {
                return new SendMinMessage();
            }
            else if (parameter == "email")
            {
                return new SendEmail();
            }
            throw new ApplicationException();
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
