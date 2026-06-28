using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    internal class StrategyDesignPattern
    {
        // something
    }

    public interface IShippeingStrategy
    {
        decimal Calrate(double packageWeight);
    }

    public class FedexStrategy : IShippeingStrategy
    {
        public decimal Calrate(double weight)
        {
            return (decimal)(weight * 2.50) + 10.00m;
        }
    }
    public class UpsStrategy : IShippeingStrategy
    {
        public decimal Calrate(double weight)
        {
            return (decimal)(weight * 3.10) + 10.00m;
        }
    }
    public class DhlStrategy : IShippeingStrategy
    {
        public decimal Calrate(double weight)
        {
            return (decimal)(weight * 5.50) + 10.00m;
        }
    }

    public class ShippingCalculate
    {
        private IShippeingStrategy _shippingStrategy;

        public ShippingCalculate(IShippeingStrategy shippeingStrategy)
        {
            _shippingStrategy= shippeingStrategy;
        }

        public void SetStrategy(IShippeingStrategy shippeingStrategy)
        {
            _shippingStrategy = shippeingStrategy;
        }

        public decimal ComputeCost(double packgeWeight)
        {
            if (_shippingStrategy==null)
                throw new InvalidOperationException("shipping strategy is not set");
            
            return _shippingStrategy.Calrate(packgeWeight);
        }
    }
}
