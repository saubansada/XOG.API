using System.Web.Optimization;

namespace XOG
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //foreach (var directory in ThemeHelper.GetThemeDirectories())
            //{
            //    var cssBundle = new StyleBundle(string.Format("~/Theme_{0}", directory));

            //    cssBundle.Include(MvcThemeStylesheetsHelper.GetPathsFromSettings(directory));

            //    bundles.Add(cssBundle);

            //    var scriptBundle = new ScriptBundle(string.Format("~/Script_{0}", directory));

            //    scriptBundle.Include(MvcThemeScriptsHelper.GetPathsFromSettings(directory));

            //    bundles.Add(scriptBundle);
            //}

            //foreach (var package in ThemeHelper.GetBundlePackages())
            //{

            //    var ScriptBundle = new ScriptBundle(string.Format("~/Script_{0}", package));

            //    ScriptBundle.Include(MvcThemeScriptsHelper.GetPathsFromXMLPackage(package));

            //    bundles.Add(ScriptBundle);
            //}

            //BundleTable.EnableOptimizations = AppConfig.EnableBundleOptimization;

            //if (HttpContext.Current.IsDebuggingEnabled)
            //{
            //    foreach (var bundle in BundleTable.Bundles)
            //    {
            //        bundle.Transforms.Clear();
            //    }
            //}

        }

        //public static void RegisterBundles(BundleCollection bundles)
        //{
        //    bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
        //                "~/Scripts/jquery-{version}.js"));

        //    bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
        //                "~/Scripts/jquery.validate*"));

        //    bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
        //                "~/Scripts/modernizr-*"));

        //    bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
        //              "~/Scripts/bootstrap.js",
        //              "~/Scripts/respond.js"));

        //    bundles.Add(new StyleBundle("~/Content/css").Include(
        //              "~/Content/bootstrap.css",
        //              "~/Content/site.css"));
        //}
    }
}
