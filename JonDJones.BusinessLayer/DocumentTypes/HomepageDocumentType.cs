using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vega.USiteBuilder;

namespace JonDJones.BusinessLayer.DocumentTypes
{
    [DocumentType(Name = "Homepage",
                  Alias="homepage",
                  Description = "The Homepage",
                  AllowedChildNodeTypes = new Type[] { typeof(ContentDocumentType) } )]
    public class HomepageDocumentType : Vega.USiteBuilder.DocumentTypeBase
    {
        [DocumentTypeProperty(UmbracoPropertyType.Textstring, 
            Name = "Page Title", 
            Tab = "Page Setting", 
            Description = "Page Title")]
        public string PageTitle { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.RichtextEditor, 
            Name = "Page Title", 
            Tab = "Page Setting", 
            Description = "Page Title")]
        public string Content { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.ContentPicker,
            Name = "Menu Link",
            Tab = "Menu Setting",
            Description = "Menu Link")]
        public string MenuLink { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring, 
            Name = "Website Title", 
            Tab = "Layout Settings", 
            Description = "Website Title")]
        public string WebsiteTitle { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring,
            Name = "Website Sub Title", 
            Tab = "Layout Settings",
            Description = "Website Sub Title")]
        public string WebsiteSubTitle { get; set; }
        
    }   
}