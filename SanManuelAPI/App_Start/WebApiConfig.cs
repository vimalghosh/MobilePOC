using Microsoft.Practices.Unity;
using SanManuelAPI.Contracts;
using SanManuelAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SanManuelAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var container = new UnityContainer();
            container.RegisterType<INovatusRepository, NovatusRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<ILawsonRepository, LawsonRepository>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);

        }
    }
}
