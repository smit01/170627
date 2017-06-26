using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.OData.Builder;
using System.Web.Http.OData.Extensions;
using Lab_oData.Models;

namespace Lab_oData
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

            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Customers>("Customers");
            builder.EntitySet<Orders>("Orders");
            builder.EntitySet<Order_Details>("Order_Details");
            builder.EntitySet<Products>("Products");
            config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());


        }
    }
}
