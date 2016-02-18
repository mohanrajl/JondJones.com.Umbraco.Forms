using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vega.USiteBuilder;

namespace JonDJones.BusinessLayer.DocumentTypes
{
    [DocumentType(Name = "Mega Menu Container",
                  Description = "This is the container for the meag menu.",
                  AllowedChildNodeTypes = new Type[] { typeof(MenuDocumentType) } )]
    public class MenuContainerDocumentType : Vega.USiteBuilder.DocumentTypeBase
    {
    }   
}