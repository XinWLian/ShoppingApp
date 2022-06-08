using ShoppingApp.Model.Items.MeasurementState;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Model.Items.Produce
{
    public class Lettuce : ItemEntity
    {
        public Lettuce(Customer customer) : base(customer)
        {
            Price = 1.5;
            ItemName = "Lettuce";
            ItemType = new ItemTypeState.Produce();
            MeasurementType = new Whole(this);
        }
    }
}
