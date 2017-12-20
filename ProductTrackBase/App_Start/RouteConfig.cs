using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProductTrack
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Member Create",
                url: "Members/Create",
                defaults: new { controller = "Members", action = "Create" }
            );

            routes.MapRoute(
                name: "Member Edit",
                url: "Members/Edit/{user_id}",
                defaults: new { controller = "Members", action = "Edit", user_id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Member Details",
                url: "Members/Details/{user_id}",
                defaults: new { controller = "Members", action = "Details", user_id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Member Delete",
                url: "Members/Delete/{user_id}",
                defaults: new { controller = "Members", action = "Delete", user_id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Member",
                url: "TimeSummary/Members/{member_user_id}",
                defaults: new { controller = "TimeSummary", action = "Member", member_user_id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
