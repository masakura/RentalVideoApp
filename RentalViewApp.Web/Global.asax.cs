using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using RentalViewApp.Web.Models;

namespace RentalViewApp.Web
{
    public class Global : HttpApplication
    {
        private void Application_Start(object sender, EventArgs e)
        {
            Database.SetInitializer(new DbInitializer());

            using (var dbContext = new ApplicationDbContext())
            {
                // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
                dbContext.Videos.FirstOrDefault();

                Debug.WriteLine(dbContext.Database.Connection.ConnectionString);
            }

            // アプリケーションのスタートアップで実行するコードです
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}