using ShoppingApp.Model.Items.MeasurementState;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Model.Items.Frozen
{
    public class IceCream : ItemEntity
    {
        public IceCream(Customer customer) : base(customer)
        {
            Price = 2.8;
            ItemName = "Ice Cream";
            ItemType = new ItemTypeState.Frozen();
            MeasurementType = new Whole(this);
        }
    }
}
