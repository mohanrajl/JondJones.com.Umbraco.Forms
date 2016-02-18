using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vega.USiteBuilder;

namespace JonDJones.BusinessLayer.DocumentTypes
{
    [DocumentType(Name = "Content Page",
                  Description = "Content Page")]
    public class ContentDocumentType : Vega.USiteBuilder.DocumentTypeBase
    {
        [DocumentTypeProperty(UmbracoPropertyType.Textstring, 
            Name = "Page Title", 
            Tab = "Homepage Setting", 
            Description = "Page Title")]
        public string PageTitle { get; set; }
    }   
}