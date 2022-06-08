using ShoppingApp.Model.Items;
using ShoppingApp.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ShoppingApp.Commands
{
    public class DecrementCommand:CommandBase
    {
        public ItemEntity _item;
        private readonly ItemsViewModel _itemViewModel;
        public DecrementCommand(ItemEntity item,ItemsViewModel itemViewModel)
        {
            _itemViewModel = itemViewModel;
            _item = item;
        }


        public override void Execute(object parameter)
        {
            _item.Decrement();
        }
    }
}
