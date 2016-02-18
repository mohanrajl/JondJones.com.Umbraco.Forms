using JonDJones.BusinessLayer.Interfaces;
using JonDJones.BusinessLayer.ViewModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Vega.USiteBuilder;

namespace JondJonesSampleSite
{
    public class LayoutViewModelResultFilter : IResultFilter
    {
        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            var model = filterContext.Controller.ViewData.Model;

            var layoutModel = model as ILayoutViewModel<DocumentTypeBase>;
            if (layoutModel != null)
            {
                var layout = new LayoutViewModel();
                layoutModel.Layout = layout;
            }
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
        }
    }
}
