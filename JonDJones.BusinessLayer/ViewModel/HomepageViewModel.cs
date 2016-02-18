using JonDJones.BusinessLayer.DocumentTypes;
using JonDJones.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JonDJones.BusinessLayer.ViewModel
{
    public class HomepageViewModel : BaseViewModel<HomepageDocumentType>
    {
        private readonly HomepageDocumentType _currentPage;

        public HomepageViewModel(HomepageDocumentType currentPage)
            : base(currentPage)
        {
        }
    }
}