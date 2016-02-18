using JonDJones.BusinessLayer.DocumentTypes;
using JonDJones.BusinessLayer.Models;
using JonDJones.BusinessLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Vega.USiteBuilder;

namespace JondJonesSampleSite.Controllers
{
    public class HomePageController : Umbraco.Web.Mvc.RenderMvcController
    {

        public ActionResult homepage(RenderModel model)
        {
            var homepage = ContentHelper.GetByNodeId<HomepageDocumentType>(model.Content.Id);
            var homepageViewModel = new HomepageViewModel(homepage);

            return CurrentTemplate(homepageViewModel);
        }
    }
}