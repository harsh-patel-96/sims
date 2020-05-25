using System.Web;
using System.Web.Optimization;

namespace SIMS
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

            bundles.Add(new ScriptBundle("~/Js").Include(
                      "~/Content/plugins/jquery/jquery.min.js",
                      "~/Content/plugins/bootstrap/js/bootstrap.bundle.min.js",
                      "~/Content/dist/js/adminlte.min.js",
                      "~/Content/plugins/select2/js/select2.full.min.js",
                      "~/Content/plugins/moment/moment.min.js",
                      "~/Content/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js",
                      "~/Content/plugins/daterangepicker/daterangepicker.js",
                      "~/Content/plugins/moment/moment.min.js",
                      "~/Content/plugins/inputmask/min/jquery.inputmask.bundle.min.js"));


            bundles.Add(new StyleBundle("~/Css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/dist/css/AdminLTE.min.css",
                      "~/Content/plugins/fontawesome-free/css/all.min.css",
                      "~/Content/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css",
                      "~/Content/plugins/select2/css/select2.min.css",
                      "~/Content/plugins/select2-bootstrap4-theme/select2-bootstrap4.min.css",
                      "~/Content/plugins/daterangepicker/daterangepicker.css"));
            BundleTable.EnableOptimizations = true;
        }
    }
}
