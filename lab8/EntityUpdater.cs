using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab8
{
    public abstract class EntityUpdater
    {
        public void UpdateEntity()
        {
            var entity = GetEntity();
            if (ValidateEntity(entity))
            {
                SaveEntity(entity);
                SendResponse();
            }
            else
            {
                HandleValidationError();
            }
            System.Console.WriteLine();
        }

        protected abstract object GetEntity();
        protected abstract bool ValidateEntity(object entity);
        protected abstract void SaveEntity(object entity);
        protected abstract void SendResponse();

        protected virtual void HandleValidationError() { }
    }
}