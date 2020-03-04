using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Sentry.AspNetCore;
using Sentry.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentryDemo
{
    public class MyUserFactory : IUserFactory
    {
        public User Create(HttpContext context)
        {
            Console.WriteLine("myUserFactory");
            return new User()
            {
                Username = context.User.Identity.Name,
                Id = JsonConvert.SerializeObject(context.User.Claims),
                IpAddress = context.Connection.RemoteIpAddress.ToString(),
            };
        }
    }
}
