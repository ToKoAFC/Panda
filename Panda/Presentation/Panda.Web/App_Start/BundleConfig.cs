using System.Web;
using System.Web.Optimization;

namespace Panda.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            
            //AngularJS scripts
            bundles.Add(new ScriptBundle("~/bundles/angularJS").Include(
                        "~/Scripts/angular/angular.min.js",
                        "~/Scripts/angular-route/angular-route.min.js",
                        "~/Scripts/angular-animate/angular-animate.min.js",
                        "~/Scripts/angular-aria/angular-aria.min.js",
                        "~/Scripts/angular-messages/angular-messages.min.js",
                        "~/Scripts/angular-material/angular-material.js",
                        "~/Scripts/angular-material-icons/angular-material-icons.min.js",
                        "~/Scripts/md-data-table/md-data-table.min.js"

            ));
            //AngularJS stylesheets
            bundles.Add(new StyleBundle("~/Content/angularJS").Include(
                      "~/Content/angular-material/angular-material.min.css",
                      "~/Scripts/md-data-table/md-data-table.min.css"
            ));
            

        }
    }
}
