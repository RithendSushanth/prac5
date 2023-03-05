using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Pract5_072
{
    public class Global : HttpApplication
    {
        /*void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }*/

        void Application_Start(object sender, EventArgs e)
        {
            Application.Lock();
            Application["tusers"] = 0;
            Application["ousers"] = 0;
            Application.UnLock();
        }

        void Application_End(object sender, EventArgs e)
        {
            //Code that runs on application shutdown
        }

        void Application_Error(object sender, EventArgs e)
        {
            //Code that runs when an unhandled errors occurs
        }
        void Session_Start(object sender, EventArgs e)
        {
            int tusers, ousers;
            Application.Lock();
            tusers = int.Parse(Application["tusers"].ToString()) + 1;
            ousers = int.Parse(Application["ousers"].ToString()) + 1;
            Application["tusers"] = tusers;
            Application["ousers"] = ousers;
            Application.UnLock();
        }

        void Session_End(object sender, EventArgs e)
        {
            int ousers;
            Application.Lock();
            ousers = int.Parse(Application["ousers"].ToString()) - 1;
            Application["ousers"] = ousers;
            Application.UnLock();
        }
    }
}