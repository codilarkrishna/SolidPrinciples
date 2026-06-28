using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    internal class FacadeDesignPattern
    {
    }
    public class InventorySystem
    {
        public bool IsInStock(int itemId) => true;
        public void DeductStock(int itemId) => Console.WriteLine($"Item {itemId} deducted from the stock");
    }
    public class  PaymentGateway()
    {
        public bool Chaarge(decimal price) => true;
        
    }
    public class LogisticsSystem
    {
        //fgdfgdf
        public void CreateShipment(int itemid) => Console.WriteLine($"shipment label creaeted for item {itemid}");
    }
    public class NotificationService
    {
        public void SendOrderConfirmation() => Console.WriteLine("confirmation email dispatched");
    }

    public class OrderProcessingFacade
    {
        private readonly InventorySystem _inventorySystem = new();
        private readonly PaymentGateway _paymentGateway = new();
        private readonly LogisticsSystem _logisticsSystem = new();
        private readonly NotificationService _notificationService = new();

        // add something
        public bool PlaceOrder(int itemid, decimal price)
        {
            Console.WriteLine("Facade: Starting order processing pipeline");
            if(!_inventorySystem.IsInStock(itemid)) return false;
            if(!_paymentGateway.Chaarge(price)) return false;

            _inventorySystem.DeductStock(itemid);
            _logisticsSystem.CreateShipment(itemid);
            _notificationService.SendOrderConfirmation();

            Console.WriteLine("Facade: Orde completed successfuly");
            return true;
        }
    }
}
