using ShoppingApp.Model;
using ShoppingApp.Stores;
using ShoppingApp.ViewModel.ItemPageViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Commands.Selectors
{
    public class SelectFrozenCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;
        private Customer _customer;
        public SelectFrozenCommand(Customer customer, NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            _customer = customer;
        }
        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new FrozenPageViewModel(_customer);
        }
    }
}
