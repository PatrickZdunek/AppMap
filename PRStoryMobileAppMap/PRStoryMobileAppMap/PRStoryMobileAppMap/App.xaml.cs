using Prism;
using Prism.Ioc;
using Prism.DryIoc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PRStoryMobileAppMap.Views;
using PRStoryMobileAppMap.ViewModels;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PRStoryMobileAppMap
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync("NavigationPage/LoginPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<MasterDetail, MasterDetailViewModel>();
            containerRegistry.RegisterForNavigation<MPUSelectionPage, MPUSelectionPageViewModel>();
            containerRegistry.RegisterForNavigation<BenchmarkingPage, BenchmarkingPageViewModel>();
            containerRegistry.RegisterForNavigation<DocumentViewerPage, DocumentViewerPageViewModel>();
            containerRegistry.RegisterForNavigation<AboutPage, AboutPageViewModel>();
        }
    }
}
