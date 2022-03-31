using System.Web.Optimization;
using System.Web.Mvc;
namespace eUseControl.Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            // Bootstrap style
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include("~/Content/bootstrap.min.css"));

            // Elegant-icons
            bundles.Add(new StyleBundle("~/bundles/elegant-icons/css").Include("~/Content/elegant-icons.css"));
            // font-awesome
            bundles.Add(new StyleBundle("~/bundles/font-awesome/css").Include("~/Content/font-awesome.min.css"));
            // jquery-ui
            bundles.Add(new StyleBundle("~/bundles/jquery-ui/css").Include("~/Content/jquery-ui.min.css"));

            // nice-select
            bundles.Add(new StyleBundle("~/bundles/nice-select/css").Include("~/Content/nice-select.css"));
            // owl.carousel
            bundles.Add(new StyleBundle("~/bundles/owl.carousel/css").Include("~/Content/owl.carousel.min.css"));
            // slicknav
            bundles.Add(new StyleBundle("~/bundles/slicknav/css").Include("~/Content/slicknav.min.css"));
            // style
            bundles.Add(new StyleBundle("~/bundles/style/css").Include("~/Content/style.css"));



            // Bootstrap
            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include("~/Scripts/bootstrap.min.js"));

            // jquery-ui
            bundles.Add(new ScriptBundle("~/bundles/jquery-ui/js").Include("~/Scripts/jquery-ui.min.js"));
            // jquery.nice-select
            bundles.Add(new ScriptBundle("~/bundles/jquery.nice-select/js").Include("~/Scripts/jquery.nice-select.min.js"));
            // jquery.slicknav
            bundles.Add(new ScriptBundle("~/bundles/jquery.slicknav/js").Include("~/Scripts/jquery.slicknav.js"));


            // main
            bundles.Add(new ScriptBundle("~/bundles/main/js").Include("~/Scripts/main.js"));
            // mixitup
            bundles.Add(new ScriptBundle("~/bundles/mixitup/js").Include("~/Scripts/mixitup.min.js"));

            // owl.carousel
            bundles.Add(new ScriptBundle("~/bundles/owl.carousel/js").Include("~/Scripts/owl.carousel.min.js"));
            // jquery-3.3.1
            bundles.Add(new ScriptBundle("~/bundles/jquery-3.3.1/js").Include("~/Scripts/jquery-3.3.1.min.js"));


        }
    }
}