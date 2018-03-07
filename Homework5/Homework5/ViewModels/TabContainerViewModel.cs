using System;
using System.Diagnostics;
using Prism.Mvvm;
using Prism.Navigation;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Homework5.ViewModels
{
    public class TabContainerViewModel : BindableBase,INavigationAware
    {
        public TabContainerViewModel()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(TabContainerViewModel)}:  ctor");
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnNavigatedFrom)}");  
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnNavigatedTo)}");
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnNavigatingTo)}");
        }
    }
}
