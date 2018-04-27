using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Server.Kestrel;
using System;

namespace DdfApi
{
    class Program
    {
        static void Main(string[] args)
        {
            var webhost = new WebHostBuilder()
                .UseKestrel()
                .Configure(app => { app.Use((context, next)
                    => context.Response.WriteAsync("Hello World!"));
                })
                .Build();
            webhost.Run();
        }
    }
}
