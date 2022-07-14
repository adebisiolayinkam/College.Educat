using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.UI;

namespace College.Educat
{
    public class BundleConfig
    {
        // For more information on Bundling, visit https://go.microsoft.com/fwlink/?LinkID=303951
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/WebFormsJs").Include(
                            "~/Scripts/WebForms/WebForms.js",
                            "~/Scripts/WebForms/WebUIValidation.js",
                            "~/Scripts/WebForms/MenuStandards.js",
                            "~/Scripts/WebForms/Focus.js",
                            "~/Scripts/WebForms/GridView.js",
                            "~/Scripts/WebForms/DetailsView.js",
                            "~/Scripts/WebForms/TreeView.js",
                            "~/Scripts/WebForms/WebParts.js"));

            // Order is very important for these files to work, they have explicit dependencies
            bundles.Add(new ScriptBundle("~/bundles/MsAjaxJs").Include(
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjax.js",
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjaxApplicationServices.js",
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjaxTimer.js",
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjaxWebForms.js"));


            bundles.Add(new ScriptBundle("~/Dashboard/js").Include(
                    "~/assets/js/jquery-1.10.2.js",
                    "~/assets/js/bootstrap.min.js",
                    "~/assets/js/jquery.metisMenu.js",
                    "~/assets/js/custom.js"
                    ));

            bundles.Add(new ScriptBundle("~/NewDashboard/js").Include(
                    "~/content/vendor/jquery/jquery.min.js",
                    "~/content/vendor/bootstrap/js/bootstrap.bundle.min.js",
                    "~/content/vendor/jquery-easing/jquery.easing.min.js",
                    "~/content/vendor/chart.js/Chart.min.js",
                    "~/content/vendor/datatables/jquery.dataTables.js",
                    "~/content/vendor/datatables/dataTables.bootstrap4.js",
                    "~/content/js/sb-admin.min.js",
                    "~/content/js/datatables.js"
                    ));
            // Use the Development version of Modernizr to develop with and learn from. Then, when you’re
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                            "~/Scripts/modernizr-*"));
        }
    }
}