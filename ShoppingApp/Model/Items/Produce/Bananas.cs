using ShoppingApp.Model.Items.MeasurementState;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Model.Items.Produce
{
    public class Bananas : ItemEntity
    {
        public Bananas(Customer customer) : base(customer)
        {
            Price = .5;
            ItemName = "Bananas(lb)";
            ItemType = new ItemTypeState.Produce();
            MeasurementType = new Measured(this);
        }
    }
}
