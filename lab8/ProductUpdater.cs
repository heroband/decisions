using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab8
{
    public class ProductUpdater : EntityUpdater
    {
        protected override object GetEntity()
        {
            return new Product();
        }

        protected override bool ValidateEntity(object entity)
        {
            // Логіка валідації
            return true;
        }

        protected override void SaveEntity(object entity)
        {
            Console.WriteLine("Product saved");
        }

        protected override void SendResponse()
        {
            Console.WriteLine("Response: Status Code, Status");
        }

        protected override void HandleValidationError()
        {
            Console.WriteLine("Validation failed: Admin notified about validation failure for Product.");
        }
    }
}