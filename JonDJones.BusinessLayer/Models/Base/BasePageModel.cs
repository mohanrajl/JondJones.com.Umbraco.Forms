using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Web.Models;

namespace JonDJones.BusinessLayer.Models.Base
{
    public class BasePageModel : RenderModel
    {
        public BasePageModel(IPublishedContent content)
            : base(content)
        {

        }
    }
}