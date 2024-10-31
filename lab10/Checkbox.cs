using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab10
{
    public class Checkbox : Component
    {
        private bool isChecked;

        public void ToggleCheck()
        {
            isChecked = !isChecked;
            Console.WriteLine($"Checkbox: Стан змінено на {(isChecked ? "вибрано" : "не вибрано")}");
            NotifyMediator("CheckedChanged");
        }

        public bool IsChecked()
        {
            return isChecked;
        }

        public void SetEnabled(bool isEnabled)
        {
            Console.WriteLine($"Checkbox: Стан активності - {isEnabled}");
        }
    }
}