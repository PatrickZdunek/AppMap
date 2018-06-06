using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using PRStoryMobileAppMap.Infrastructure;

namespace PRStoryMobileAppMap.ViewModels
{
    public class DocumentViewerPageViewModel : AppMapViewModelBase
    {


        public DocumentViewerPageViewModel(INavigationService navigationService) : base (navigationService)
        {
        }
    }
}
