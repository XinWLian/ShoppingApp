using ShoppingApp.Model.Items.MeasurementState;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Model.Items.Produce
{
    public class Pineapple : ItemEntity
    {
        public Pineapple(Customer customer) : base(customer)
        {
            Price = 1.8;
            ItemName = "Pineapples";
            ItemType = new ItemTypeState.Produce();
            MeasurementType = new Whole(this);
        }
    }
}
