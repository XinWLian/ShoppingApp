using ShoppingApp.Model;
using ShoppingApp.Model.Items;
using ShoppingApp.Model.Items.ItemTypeState;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.ViewModel.ItemPageViewModel
{
    public class FrozenPageViewModel : ItemPageViewModel
    {
        public FrozenPageViewModel(Customer customer) : base(customer)
        {
        }
        public override void ProcessPage()
        {
            foreach (ItemEntity product in _customer.Item)
            {
                if (product.ItemType is Frozen)
                {
                    ItemsViewModel item = new ItemsViewModel(product);
                    _items.Add(item);
                }
            }
        }
    }
}
