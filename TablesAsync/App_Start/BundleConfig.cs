using System.Web;
using System.Web.Optimization;

namespace TablesAsync
{
	public class BundleConfig
	{
		// For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
						"~/Scripts/asyncTables.js",
						"~/Scripts/jquery-3.4.1.min.js"));

			bundles.Add(new StyleBundle("~/Content/css").Include(
						"~/Content/bootstrap.min.css",
					  "~/Content/table.css",
					  "~/Content/site.css"));
		}
	}
}
