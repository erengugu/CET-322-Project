using System.Web.Optimization;

namespace PersonalWebPage_MVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery.js",
                "~/Scripts/jquery-3.3.1.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryother").Include(
                "~/Scripts/jquery.dcjqaccordion.2.7.js",
                "~/Scripts/jquery.scrollTo.min.js",
                "~/Scripts/jquery.nicescroll.js",
                "~/Scripts/jquery.sparkline.js",
                "~/Scripts/jquery.easy-pie-chart.js",
                "~/Scripts/jquery.customSelect.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/other").Include(
                "~/Scripts/owl.carousel.js",
                "~/Scripts/respond.min.js",
                "~/Scripts/common-scripts.js",
                "~/Scripts/sparkline-chart.js",
                "~/Scripts/easy-pie-chart.js",
                "~/Scripts/count.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Styles/bootstrap.min.css",
                "~/Styles/bootstrap-reset.css",
                "~/Styles/font-awesome.css",
                "~/Styles/jquery.easy-pie-chart.css",
                "~/Styles/owl.carousel.css",
                "~/Styles/style.css",
                "~/Styles/style-responsive.css"));
        }
    }
}