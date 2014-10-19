using System.Web.Optimization;

namespace MySpaProject.WebSpaAngular
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();

            //~/App/Main/css //TODO: Does it includes both .css and .min.css?
            bundles.Add(new StyleBundle("~/Bundles/App/Main/css").IncludeDirectory("~/App/Main", "*.css", true));

            //~/App/Main/js //TODO: Does it includes both .js and .min.js?
            bundles.Add(new ScriptBundle("~/Bundles/App/Main/js").IncludeDirectory("~/App/Main", "*.js", true));
        }
    }
}