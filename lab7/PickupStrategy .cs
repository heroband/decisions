using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab7
{
    public class PickupStrategy : IDeliveryStrategy
    {
        public decimal CalculatePrice(decimal orderAmount)
        {
            return 0; // pickup is free
        }
    }
}