using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab2
{
    public class FacebookFactory : SocialNetworkFactory
    {
        private string Login;
        private string Password;

        public FacebookFactory(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public override ISocialNetwork CreateSocialNetwork()
        {
            return new Facebook(Login, Password);
        }
    }
}