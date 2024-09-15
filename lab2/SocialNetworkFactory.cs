using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab2
{
    public abstract class SocialNetworkFactory
    {
        public abstract ISocialNetwork CreateSocialNetwork();
        public void PublishMessage(string message)
        {
            ISocialNetwork socialNetwork = CreateSocialNetwork();
            socialNetwork.LogIn();
            socialNetwork.SendMessage(message);
        }
    }
}