using Nancy;
using System;
using System.Linq;

namespace WebApi
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("/", args =>
            {
                var headers = string.Join(", ", Request.Headers.Values.SelectMany(i => i));
                return $"Hello World, it's Nancy on .NET Core ({Request.Headers.Host}, {string.Join(", ", Request.Headers["X-Forwarded-For"])}, {DateTime.Now})";
            });
        }
    }
}