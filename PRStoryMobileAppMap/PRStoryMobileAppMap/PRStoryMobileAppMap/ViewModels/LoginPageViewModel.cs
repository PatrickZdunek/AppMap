using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using PRStoryMobileAppMap.Infrastructure;

namespace PRStoryMobileAppMap.ViewModels
{
    public class LoginPageViewModel : AppMapViewModelBase
    {


        public LoginPageViewModel(INavigationService navigationService) : base (navigationService)
        {
        }
    }
}
