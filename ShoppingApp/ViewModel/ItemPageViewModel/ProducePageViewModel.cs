using ShoppingApp.Model;
using ShoppingApp.Model.Items;
using ShoppingApp.Model.Items.ItemTypeState;
using ShoppingApp.Model.Items.Produce;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.ViewModel.ItemPageViewModel
{
    public class ProducePageViewModel : ItemPageViewModel
    {
        public ProducePageViewModel(Customer customer):base(customer)
        {
        }
        public override void ProcessPage()
        {
            foreach(ItemEntity product in _customer.Item)
            {
                if (product.ItemType is Produce)
                {
                    ItemsViewModel item = new ItemsViewModel(product);
                    _items.Add(item);
                }
            }
        }
    }
}
