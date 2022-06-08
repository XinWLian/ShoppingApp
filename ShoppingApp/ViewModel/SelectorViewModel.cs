using ShoppingApp.Commands.Selectors;
using ShoppingApp.Model;
using ShoppingApp.Stores;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ShoppingApp.ViewModel
{
    public class SelectorViewModel:ViewModelBase
    {
        private Customer _customer;
        public ICommand SelectProduceCommand { get; }
        public ICommand SelectMeatCommand { get; }
        public ICommand SelectFrozenCommand { get; }
        public ICommand SelectBeverageCommand { get; }
        public SelectorViewModel(Customer customer, NavigationStore navigationStore)
        {
            _customer = customer;
            SelectProduceCommand = new SelectProduceCommand(_customer, navigationStore);
            SelectMeatCommand = new SelectMeatCommand(_customer, navigationStore);
            SelectFrozenCommand = new SelectFrozenCommand(_customer, navigationStore);
            SelectBeverageCommand = new SelectBeverageCommand(_customer, navigationStore);
        }
    }
}
