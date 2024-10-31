using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab10
{
    public class TextField : Component
    {
        private bool _isEnabled;

        public void SetEnabled(bool isEnabled)
        {
            _isEnabled = isEnabled;
            Console.WriteLine($"TextField: Стан активності - {_isEnabled}");
        }
    }
}