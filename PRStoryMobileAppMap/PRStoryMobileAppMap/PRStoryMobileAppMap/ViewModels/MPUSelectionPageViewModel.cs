using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using PRStoryMobileAppMap.Infrastructure;

namespace PRStoryMobileAppMap.ViewModels
{
    public class MPUSelectionPageViewModel : AppMapViewModelBase
    {


        public MPUSelectionPageViewModel(INavigationService navigationService) : base (navigationService)
        {
        }
    }
}
