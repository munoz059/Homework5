using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Homework5.Views;
using Xamarin.Forms;

namespace Homework5.ViewModels
{
    public class MainPageViewModel : BindableBase ,INavigationAware
    {
        INavigationService _navigationService;

        public DelegateCommand NavigateToTabContainerCommand { get; set; }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainPageViewModel(INavigationService navigationService)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(MainPageViewModel)}:  ctor");

            Title = "Main Page";
            _navigationService = navigationService;
            NavigateToTabContainerCommand = new DelegateCommand(OnNavigateToTabContainer);
           
        }

        private void OnNavigateToTabContainer()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnNavigateToTabContainer)}");
         
            //TabContainer in views not viewModels 
            _navigationService.NavigateAsync(nameof(TabContainer));

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
