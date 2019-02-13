using System.Web;
using System.Web.Optimization;

namespace Unitube
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Content/vendor/jquery/jquery.min.js",
                        "~/Content/vendor/jquery-easing/jquery.easing.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Content/js/unitube-min.js",
                      "~/Content/vendor/bootstrap/js/bootstrap.bundle.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/unitube.css",
                      "~/Content/unitube-min.css",
                      "~/Content/vendor/fontawesome-free/css/all.min.css",
                      "~/Content/vendor/simple-line-icons/css/simple-line-icons.css",
                      "~/Content/device-mockups/device-mockups.min.css"));
        }
    }
}
