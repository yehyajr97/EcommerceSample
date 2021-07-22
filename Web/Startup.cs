﻿using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;

[assembly: OwinStartup(typeof(Web.Startup))]

namespace Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions() { 
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                ExpireTimeSpan = TimeSpan.FromDays(1),
                LoginPath = new PathString("/Account/Login")
            });


            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
        }

        public class RouteConfig
        {
            public static void RegisterRoutes(RouteCollection routes)
            {
                routes.MapMvcAttributeRoutes();
            }
        }
    }
}
