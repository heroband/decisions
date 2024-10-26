using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab8
{
    public class OrderUpdater : EntityUpdater
    {
        protected override object GetEntity()
        {
            return new Order();
        }

        protected override bool ValidateEntity(object entity)
        {
            // Логіка валідації
            return true;
        }

        protected override void SaveEntity(object entity)
        {
            System.Console.WriteLine("Order saved");
        }

        protected override void SendResponse()
        {
            System.Console.WriteLine("Response: Status Code, Status, Order JSON");
        }

        protected override void HandleValidationError()
        {
            Console.WriteLine("Validation failed: Custom error handling for Order.");
        }
    }
}