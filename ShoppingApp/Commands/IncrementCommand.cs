using ShoppingApp.Model.Items;
using ShoppingApp.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ShoppingApp.Commands
{
    public class IncrementCommand:CommandBase
    {
        public ItemEntity _item;
        private readonly ItemsViewModel _itemViewModel;
        public IncrementCommand(ItemEntity item, ItemsViewModel itemViewModel)
        {
            _itemViewModel = itemViewModel;
            _item = item;
        }

        public override void Execute(object parameter)
        {
            _item.Increment();
        }
    }
}
