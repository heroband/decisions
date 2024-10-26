using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab8
{
    public class User
    {
        public string Email { get; set; }
        private string originalEmail = "current@example.com";

        public bool IsEmailModified()
        {
            return Email != originalEmail;
        }
    }
}