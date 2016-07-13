using System.Web;
using System.Web.Optimization;

namespace NorthWind
{
    public class BundleConfig
    {
        // Para obtener más información acerca de Bundling, consulte http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/css/bootstrap.min.css",
                "~/Content/css/sb-admin.css",
                "~/Content/css/plugins/morris.css",
                "~/Content/font-awesome/css/font-awesome.min.css"
                ));
  

            bundles.Add(new ScriptBundle("~/Scripts/js").Include(
                "~/Scripts/js/jquery.js",
                "~/Scripts/js/bootstrap.min.js",
                "~/Scripts/js/plugins/morris/raphael.min.js",
                "~/Scripts/js/plugins/morris/morris.min.js",
                "~/Scripts/js/plugins/morris/morris-data.js"
                ));


            

            


        }
    }
}