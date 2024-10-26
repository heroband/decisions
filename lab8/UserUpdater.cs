using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab8
{
    public class UserUpdater : EntityUpdater
    {
        protected override object GetEntity()
        {
            return new User { Email = "current@example.com" };
        }

        protected override bool ValidateEntity(object entity)
        {
            var user = entity as User;

            if (user != null && user.IsEmailModified())
            {
                return false;
            }

            return true;
        }

        protected override void SaveEntity(object entity)
        {
            Console.WriteLine("User saved");
        }

        protected override void SendResponse()
        {
            Console.WriteLine("Response: Status Code, Status");
        }

        protected override void HandleValidationError()
        {
            Console.WriteLine("Validation failed: Cannot modify the email field for User.");
        }
    }
}