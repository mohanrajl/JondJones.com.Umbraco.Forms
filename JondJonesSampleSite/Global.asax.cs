using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace JondJonesSampleSite
{
   public class MvcApplication : Umbraco.Web.UmbracoApplication
    {
        protected override void OnApplicationStarted(object sender, EventArgs e)
        {
            RegisterGlobalFilters(GlobalFilters.Filters);
        }

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new LayoutViewModelResultFilter());
        }
    }
}
