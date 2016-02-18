using JonDJones.BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using Vega.USiteBuilder;

namespace JonDJones.BusinessLayer.ViewModel
{
    public class BaseViewModel<T> : ILayoutViewModel<T> where T : DocumentTypeBase
    {
        public BaseViewModel(T currentPage)
        {
            CurrentPage = currentPage;
        }

        public T CurrentPage { get; private set; }

        public LayoutViewModel Layout { get; set; }
    }
}