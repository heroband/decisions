using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab2
{
    public class Application
    {
        private SocialNetworkFactory socialNetworkFactory;

        public void Initialize(string networkType)
        {
            if (networkType == "Facebook")
            {
                socialNetworkFactory = new FacebookFactory("Tom", "1234qwerty");
            }
            else if (networkType == "LinkedIn")
            {
                socialNetworkFactory = new LinkedInFactory("Bob@gmail.com", "qwerty1234");
            }
            else
            {
                throw new ArgumentException("Invalid network type");
            }
        }

        public void CreateMessage(string message)
        {
            socialNetworkFactory.PublishMessage(message);
        }
    }
}