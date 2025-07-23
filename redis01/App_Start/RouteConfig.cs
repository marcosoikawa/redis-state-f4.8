using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace redis01
{
    /// <summary>
    /// Configuration class for registering application routes and friendly URLs
    /// </summary>
    public static class RouteConfig
    {
        /// <summary>
        /// Registers routes for the application including friendly URL configuration
        /// </summary>
        /// <param name="routes">The route collection to register routes with</param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);
        }
    }
}
