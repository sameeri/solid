using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using DependencyInversionPrinciple_WithAnIocContainer.Services;

namespace DependencyInversionPrinciple_WithAnIocContainer
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //config.DependencyResolver = new SimpleContainer();

            Bootstrapper.Initialise();
        }
    }
}
