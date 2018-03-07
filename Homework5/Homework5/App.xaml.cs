using Prism;
using Prism.Ioc;
using Homework5.ViewModels;
using Homework5.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Unity;
using System.Diagnostics;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Homework5
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
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnInitialized)}");
            InitializeComponent();

            await NavigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(MainPage)}");

        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(RegisterTypes)}");
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<TabContainer, TabContainerViewModel>();
            containerRegistry.RegisterForNavigation<TabA, TabAViewModel>();
            containerRegistry.RegisterForNavigation<TabB, TabBViewModel>();

        }

        protected override void OnStart()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnStart)}");
            base.OnStart();
        }

        protected override void OnSleep()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnSleep)}");
            base.OnSleep();
        }

        protected override void OnResume()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnResume)}");
            base.OnResume();
        }
    }
}
