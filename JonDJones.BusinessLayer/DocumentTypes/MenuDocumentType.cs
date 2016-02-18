using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vega.USiteBuilder;

namespace JonDJones.BusinessLayer.DocumentTypes
{
    [DocumentType(Name = "Mega Document Type",
                  Description = "Creates a new menu.",
                  AllowedChildNodeTypes = new Type[] { typeof(MenuItemDocumentType) })]
    public class MenuDocumentType : Vega.USiteBuilder.DocumentTypeBase
    {
        [DocumentTypeProperty(UmbracoPropertyType.Textstring, 
            Name = "Menu Name", 
            Tab = "Menu", 
            Description = "Menu Name")]
        public string MenuName { get; set; }
    }   
}