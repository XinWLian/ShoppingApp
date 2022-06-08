using ShoppingApp.Model;
using ShoppingApp.Model.Items;
using ShoppingApp.Model.Items.ItemTypeState;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.ViewModel.ItemPageViewModel
{
    public class BeveragePageViewModel : ItemPageViewModel
    {
        public BeveragePageViewModel(Customer customer) : base(customer)
        {
        }
        public override void ProcessPage()
        {
            foreach (ItemEntity product in _customer.Item)
            {
                if (product.ItemType is Beverages)
                {
                    ItemsViewModel item = new ItemsViewModel(product);
                    _items.Add(item);
                }
            }
        }
    }
}
