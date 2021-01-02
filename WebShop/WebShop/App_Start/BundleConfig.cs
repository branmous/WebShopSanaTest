﻿using System.Web;
using System.Web.Optimization;

namespace WebShop
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

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/assets/vendor/bootstrap/js/bootstrap.bundle.min.js",
                      "~/Content/assets/vendor/jquery.easing/jquery.easing.min.js",
                      "~/Content/assets/vendor/isotope-layout/isotope.pkgd.min.js",
                      "~/Content/assets/vendor/venobox/venobox.min.js",
                      "~/Content/assets/vendor/owl.carousel/owl.carousel.min.js",
                      "~/Content/assets/vendor/aos/aos.js",
                      "~/Content/assets/js/main.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/assets/vendor/bootstrap/css/bootstrap.min.css",
                      "~/Content/assets/vendor/icofont/icofont.min.css",
                      "~/Content/assets/vendor/boxicons/css/boxicons.min.css",
                      "~/Content/assets/vendor/animate.css/animate.min.css",
                      "~/Content/assets/vendor/remixicon/remixicon.css",
                      "~/Content/assets/vendor/line-awesome/css/line-awesome.min.css",
                      "~/Content/assets/vendor/venobox/venobox.css",
                      "~/Content/assets/vendor/owl.carousel/assets/owl.carousel.min.css",
                      "~/Content/assets/vendor/aos/aos.css",
                      "~/Content/assets/css/style.css"));
        }
    }
}
