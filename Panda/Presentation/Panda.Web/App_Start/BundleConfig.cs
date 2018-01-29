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


            bundles.Add(new StyleBundle("~/Content/angular").Include(
                      "~/Scripts/angular/angular-material.min.css",
                      "~/Scripts/angular/angular-material.css",
                      "~/Scripts/angular/md-data-table.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/angularJS").Include(
                      "~/Scripts/angular/angular.js",
                      "~/Scripts/angular/angular-route.js",
                      "~/Scripts/angular/angular-animate.js",
                      "~/Scripts/angular/angular-aria.js",
                      "~/Scripts/angular/angular-messages.js",
                      "~/Scripts/angular/angular-material.js",
                      "~/Scripts/angular/angular-sanitize.js",
                      "~/Scripts/angular/angular-material-icons.min.js",
                      "~/Scripts/angular/angular-nguid.min.js",
                      "~/Scripts/angular/angular-nguid.js",
                      "~/Scripts/angular/md-data-table.js",
                      "~/Content/lodash/lodash.min.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/angular-mods").Include(
                "~/Angular-Components/pandaApp.js",
                "~/Angular-Components/product.service.js"));


            bundles.Add(new ScriptBundle("~/bundles/angular-modules-js").Include(
                       "~/Angular-Components/product-create.controller.js"
                      ));

        }
    }
}
