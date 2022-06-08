using ShoppingApp.Model;
using ShoppingApp.Model.Items;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace ShoppingApp.ViewModel.ItemPageViewModel
{
    public abstract class ItemPageViewModel:ViewModelBase
    {
        public Customer _customer;
        public readonly ObservableCollection<ItemsViewModel> _items;
        public IEnumerable<ItemsViewModel> Items => _items;
        public ItemPageViewModel(Customer customer)
        {
            _customer = customer;
            _items = new ObservableCollection<ItemsViewModel>();
            ProcessPage();
        }
        public abstract void ProcessPage();
    }
}
