using ShoppingApp.Commands;
using ShoppingApp.Model.Items;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ShoppingApp.ViewModel
{
    public class ItemsViewModel:ViewModelBase
    {
        private readonly ItemEntity _item;
        public string Quantity => _item.Quantity.ToString();
        public string Price => _item.Price.ToString("F");
        public string Total =>(_item.Quantity*_item.Price).ToString("F");
        public string ItemName => _item.ItemName;
        public ICommand DecrementCommand { get; }
        public ICommand IncrementCommand { get; }
        public ItemsViewModel(ItemEntity item)
        {
            _item = item;
            _item.QuantityChanged += OnQuantityChanged;
            DecrementCommand = new DecrementCommand(item,this);
            IncrementCommand = new IncrementCommand(item,this);
        }
        private void OnQuantityChanged()
        {
            OnPropertyChanged(nameof(_item.Quantity));
            OnPropertyChanged(nameof(_item.Total));
        }
    }
}
