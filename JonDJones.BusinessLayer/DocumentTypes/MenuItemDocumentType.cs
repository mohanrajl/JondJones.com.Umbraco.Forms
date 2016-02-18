using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vega.USiteBuilder;

namespace JonDJones.BusinessLayer.DocumentTypes
{
    [DocumentType(Name = "Mega Item Document Type",
                  Description = "Creates a new top level menu item.",
                  AllowedChildNodeTypes = new Type[] { typeof(SubMenuItemDocumentType) })]
    public class MenuItemDocumentType : Vega.USiteBuilder.DocumentTypeBase
    {
        [DocumentTypeProperty(UmbracoPropertyType.Textstring, 
            Name = "Menu Title",
            Description = "Menu Title",
            Tab = "Menu")]
        public string MenuTitle { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.ContentPicker,
            Name = "Menu Link",
            Description = "Menu Link",
            Tab = "Menu")]
        public string MenuLink { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.MediaPicker,
            Name = "Menu Image Url",
            Description = "Menu Image Url",
            Tab = "Menu")]
        public string MenuImageUrl { get; set; }
    }   
}