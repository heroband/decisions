using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab10
{
    public class TimeSlotSelector : Component
    {
        public void UpdateAvailableTimeSlots(string[] timeSlots)
        {
            Console.WriteLine("TimeSlotSelector: Оновлені доступні проміжки часу:");
            foreach (var slot in timeSlots)
            {
                Console.WriteLine($"- {slot}");
            }
        }

        public void SetEnabled(bool isEnabled)
        {
            Console.WriteLine($"TimeSlotSelector: Стан активності - {isEnabled}");
        }
    }
}