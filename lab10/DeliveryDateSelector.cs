using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab10
{
    public class DeliveryDateSelector : Component
    {
        public void ChangeDate(string newDate)
        {
            Console.WriteLine($"DeliveryDateSelector: Дата змінилась на {newDate}");
            NotifyMediator("DateChanged");
        }

        public void SetEnabled(bool isEnabled)
        {
            Console.WriteLine($"DeliveryDateSelector: Стан активності - {isEnabled}");
        }
    }
}