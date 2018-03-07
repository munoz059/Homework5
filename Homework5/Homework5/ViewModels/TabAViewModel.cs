using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Prism;
using Prism.Mvvm;

namespace Homework5.ViewModels
{
    public class TabAViewModel : BindableBase, IActiveAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public event EventHandler IsActiveChanged;
        private bool _isActive;
        public bool IsActive
        {
            get { return _isActive; }
            set
            {
                SetProperty(ref _isActive, value);
                IsActiveChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        public TabAViewModel()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(TabAViewModel)}:  ctor");
            Title = "Tab A";
            IsActiveChanged += OnIsActiveChanged;

        }

        private void OnIsActiveChanged(object sender, EventArgs e)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnIsActiveChanged)}: {IsActive}");
        
        }
    }
}
