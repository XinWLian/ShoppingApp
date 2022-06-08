using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Model.Items.MeasurementState
{
    public class Measured : IMeasurementType
    {
        ItemEntity _item;
        public Measured(ItemEntity item)
        {
            _item = item;
        }
        public void Decrement()
        {
            if (_item.Quantity >= .25)
            {
                _item.Quantity -= .25;
            }
        }

        public void Increment()
        {
            _item.Quantity += .25;
        }
    }
}
