using JonDJones.BusinessLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web.Models;
using Vega.USiteBuilder;

namespace JonDJones.BusinessLayer.Interfaces
{
    public interface ILayoutViewModel<out T> where T : DocumentTypeBase
    {
        LayoutViewModel Layout { get; set; }

        T CurrentPage { get; }
    }
}