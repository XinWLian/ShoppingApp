using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Model.Items.MeasurementState
{
    public class Whole:IMeasurementType
    {
        ItemEntity _item;
        public Whole(ItemEntity item)
        {
            _item = item;
        }

        public void Decrement()
        {
            if (_item.Quantity >= 1)
            {
                _item.Quantity -= 1;
            }
        }

        public void Increment()
        {
            _item.Quantity+=1;
        }
    }
}
