using ShoppingApp.Model;
using ShoppingApp.Stores;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.ViewModel
{
    public class FooterViewModel:ViewModelBase
    {
        private Customer _customer;
        public string Total => _customer.Total.ToString("F");
        public FooterViewModel(Customer customer,NavigationStore navigationStore)
        {
            _customer = customer;
            _customer.TotalChanged += OnTotalChanged;
        }
        private void OnTotalChanged()
        {

            OnPropertyChanged(nameof(_customer.Total));
        }
    }
}
