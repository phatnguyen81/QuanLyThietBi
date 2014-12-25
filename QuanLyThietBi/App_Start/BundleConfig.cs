using System.Web;
using System.Web.Optimization;

namespace QuanLyThietBi
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js",
                "~/Scripts/sb-admin-2.js"));
            bundles.Add(new ScriptBundle("~/bundles/plugins").Include(
                "~/Scripts/plugins/metisMenu/metisMenu.min.js"
                //"~/Scripts/plugins/morris/raphael.min.js",
                //"~/Scripts/plugins/morris/morris.min.js",
                //"~/Scripts/plugins/morris/morris-data.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/site.css",
                      "~/Content/sb-admin-2.css"));

            bundles.Add(new StyleBundle("~/Content/plugins").Include(
                "~/Content/plugins/metisMenu/metisMenu.min.css",
                "~/Content/plugins/morris.css",
                "~/Content/plugins/timeline.css"));

            bundles.Add(new StyleBundle("~/fonts").Include(
                "~/fonts/font-awesome/css/font-awesome.min.css"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = false;
        }
    }
}
