using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SolidPrinciples
{
    internal class FactoryPattern
    {
    }


    public interface INotification
    {
        void Send(string message);
    }

    public class EmailNotification: INotification
    {
        // Add someting
        public void Send(string message) => Console.WriteLine($"Email sent :{message}");
    }

    public class SmsNotification : INotification
    {
        public void Send(string message) => Console.WriteLine($"Sms sent :{message}");
    }
    public abstract class NotificationDeliveryService
    {
        public abstract INotification CreateNotification();

        public void DeliverMessage(string message)
        {
            var notification = CreateNotification();
            notification.Send(message);
        }
    }

    public class EmailDeliveryService : NotificationDeliveryService
    {
        public override INotification CreateNotification() => new EmailNotification();
    }
    public class SmsDeliveryService : NotificationDeliveryService
    {
        public override INotification CreateNotification() => new SmsNotification();
    }


}
