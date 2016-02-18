using JonDJones.BusinessLayer.DocumentTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Vega.USiteBuilder;

namespace JonDJones.BusinessLayer.ViewModel
{
    public class HeaderViewModel
    {
        private IEnumerable<DocumentTypeBase> menuItems;

        public HeaderViewModel(IEnumerable<DocumentTypeBase> menuItems)
        {
            this.menuItems = menuItems;
        }

        public List<MenuItemDocumentType> MenuItems
        {
            get
            {
                return menuItems.Select(x => x as MenuItemDocumentType).ToList();
            }
        }
    }
}