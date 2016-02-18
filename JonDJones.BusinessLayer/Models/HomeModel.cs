using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace JonDJones.BusinessLayer.Models
{
    public class HomeModel : RenderModel
    {
        public HomeModel()
            : base(UmbracoContext.Current.PublishedContentRequest.PublishedContent)
        {
        }
    }
}