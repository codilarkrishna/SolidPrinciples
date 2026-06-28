namespace SolidPrinciples
{
    internal class Program
    {

        public abstract class Discount()
        {
            public abstract decimal Cal(decimal value);
        }

        public class BasicDiscount : Discount
        {
            public override decimal Cal(decimal value)
            {
               return value*0.05m;
            }
        }

        public class PremiunDiscount : Discount
        {
            public override decimal Cal(decimal value)
            {
                return value * 0.15m;
            }
        }

        public class DiscountService
        {
            public decimal GetDiscount(Discount discount,decimal price)
            {
                return discount.Cal(price);
            }
        }
        static void Main(string[] args)
        {

            // Strategy pattern
            var calculator = new ShippingCalculate(new FedexStrategy());
            Console.WriteLine($"Fedex cost: {calculator.ComputeCost(10.05)}");


            calculator.SetStrategy(new DhlStrategy());
            Console.WriteLine($"DHL cost : {calculator.ComputeCost(10.5)}");

            // Facade Pattrn
            OrderProcessingFacade facade = new OrderProcessingFacade();
            facade.PlaceOrder(itemid:200,price:99.99m);


            // Factory Pattern

            NotificationDeliveryService service=new EmailDeliveryService();
            service.DeliverMessage("Saying Hello from Factory Method");

            Console.ReadLine();
        }
    }
}
