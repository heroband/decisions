using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab2
{
    public class LinkedInFactory : SocialNetworkFactory
    {
        private string Email { get; set; }
        private string Password { get; set; }
        public LinkedInFactory(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public override ISocialNetwork CreateSocialNetwork()
        {
            return new LinkedIn(Email, Password);
        }
    }
}