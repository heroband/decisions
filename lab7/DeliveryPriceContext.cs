using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab7
{
    public class DeliveryPriceContext
    {
        private IDeliveryStrategy? _deliveryStrategy;

        public void SetStrategy(IDeliveryStrategy deliveryStrategy)
        {
            _deliveryStrategy = deliveryStrategy;
        }

        public decimal CalculateCost(decimal orderAmount)
        {
            if (_deliveryStrategy == null)
            {
                throw new InvalidOperationException("Delivery strategy isn't set");
            }

            return _deliveryStrategy.CalculatePrice(orderAmount);
        }
    }
}