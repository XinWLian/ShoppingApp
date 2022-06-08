using ShoppingApp.Model;
using ShoppingApp.Stores;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.ViewModel
{
    public class MainViewModel:ViewModelBase
    {
        private NavigationStore _navigationStore;
        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;
        public ViewModelBase SelectorViewModel { get; }
        public ViewModelBase FooterViewModel { get; }
        public MainViewModel(Customer customer, NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
            SelectorViewModel = new SelectorViewModel(customer, _navigationStore);
            FooterViewModel = new FooterViewModel(customer, _navigationStore);
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
