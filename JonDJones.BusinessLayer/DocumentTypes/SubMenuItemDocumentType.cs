using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vega.USiteBuilder;

namespace JonDJones.BusinessLayer.DocumentTypes
{
    [DocumentType(Name = "Sub Menu Item Document Type",
                  Description = "Creates a new sub level menu item that sits under a menu item.")]
    public class SubMenuItemDocumentType : Vega.USiteBuilder.DocumentTypeBase
    {

        [DocumentTypeProperty(UmbracoPropertyType.Textstring,
            Name = "Menu Title",
            Description = "Menu Title",
            Tab = "Menu")]
        public string MenuTitle { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.ContentPicker,
            Name = "Menu One Link",
            Description = "Menu One Link",
            Tab = "Menu")]
        public string MenuOneLink { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring,
            Name = "Menu One Title",
            Description = "Menu One Title",
            Tab = "Menu")]
        public string MenuOneTitle { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.ContentPicker,
            Name = "Menu Two Link",
            Description = "Menu Two Link",
            Tab = "Menu")]
        public string MenuTwoLink { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring,
            Name = "Menu Two Title",
            Description = "Menu Two Title",
            Tab = "Menu")]
        public string MenuTwoTitle { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.ContentPicker,
            Name = "Menu Three Link",
            Description = "Menu Three Link",
            Tab = "Menu")]
        public string MenuThreeLink { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring,
            Name = "Menu Three Title",
            Description = "Menu Three Title",
            Tab = "Menu")]
        public string MenuThreeTitle { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.ContentPicker,
            Name = "Menu Four Link",
            Description = "Menu Four Link",
            Tab = "Menu")]
        public string MenuFourLink { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring,
            Name = "Menu Four Title",
            Description = "Menu Four Title",
            Tab = "Menu")]
        public string MenuFourTitle { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.ContentPicker,
            Name = "Menu Five Link",
            Description = "Menu Five Link",
            Tab = "Menu")]
        public string MenuFiveLink { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring,
            Name = "Menu Five Title",
            Description = "Menu Five Title",
            Tab = "Menu")]
        public string MenuFiveTitle { get; set; }
    }   
}