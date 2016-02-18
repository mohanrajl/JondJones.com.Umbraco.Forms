using JonDJones.BusinessLayer.DocumentTypes;
using JonDJones.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web;
using Vega.USiteBuilder;

namespace JonDJones.BusinessLayer.ViewModel
{
    public class LayoutViewModel
    {
        HomepageDocumentType homepageDocumentType;

        public LayoutViewModel()
        {
            var helper = new UmbracoHelper(UmbracoContext.Current);
            var rootNodes = helper.TypedContentAtRoot();

            var homeNodeByAlias = rootNodes.FirstOrDefault(x => x.Name == "Homepage");
            homepageDocumentType = ContentHelper.GetByNodeId<HomepageDocumentType>(homeNodeByAlias.Id);
        }

        public HeaderViewModel Header
        { 
            get
            {
                var menuId = Convert.ToInt32(homepageDocumentType.MenuLink);
                var menu = ContentHelper.GetByNodeId<MenuDocumentType>(menuId);

                var fdfdf = menu.GetChildren();
                return new HeaderViewModel(fdfdf);
            }
        }

        public string WebsiteTitle
        {
            get
            {
                return homepageDocumentType.WebsiteTitle;
            }
        }

        public string WebsiteSubTitle
        {
            get
            {
                return homepageDocumentType.WebsiteSubTitle;
            }
        }
    }
}