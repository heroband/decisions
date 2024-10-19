using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab7
{
    public class ExternalDeliveryStrategy : IDeliveryStrategy
    {
        public decimal CalculatePrice(decimal orderAmount)
        {
            return 5.00m; // Fixed price for external delivery
        }
    }
}