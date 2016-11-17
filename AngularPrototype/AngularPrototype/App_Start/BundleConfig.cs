using System.Web;
using System.Web.Optimization;

namespace AngularPrototype
{
	public class BundleConfig
	{
		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
        {
            // Libraries used by Angular 2
            bundles.Add(new ScriptBundle("~/bundles/angular2libs").Include(
                        "~/node_modules/core-js/client/shim.min.js",
                        "~/node_modules/zone.js/dist/zone.js",
                        "~/node_modules/reflect-metadata/Reflect.js",
                        "~/node_modules/systemjs/dist/system.src.js",
                         "~/Scripts/systemjs.config.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
					  "~/Content/site.css"));
		}
	}
}
