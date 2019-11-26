using System;
using System.Collections.Generic;
using System.Text;
using Prism.Navigation;
using XamarinApiConnection.ViewModels.Base;

namespace XamarinApiConnection.ViewModels
{
    public class Page1ViewModel : ViewModelBase
    {
        public Page1ViewModel(INavigationService navigationService) 
            : base(navigationService)
        {
        }
    }
}
