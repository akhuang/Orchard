using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Routing;

namespace Orchard.Mvc.Routes
{
    public class ShellRoute : RouteBase
    {
        public override RouteData GetRouteData(System.Web.HttpContextBase httpContext)
        {
            var data = new RouteData(this, new MvcRouteHandler());
            data.DataTokens["temp"] = "Test";
            data.Values.Add("controller", "home1");
            data.Values.Add("action", "home1");
            return data;
        }



        public override VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values)
        {
            return null;
        }
    }
}
