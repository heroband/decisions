using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab7
{
    public class OwnDeliveryStrategy : IDeliveryStrategy
    {
        public decimal CalculatePrice(decimal orderAmount)
        {
            return orderAmount * 0.1m; // 10% of the order amount for own delivery
        }
    }
}