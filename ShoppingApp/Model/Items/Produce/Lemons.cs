using ShoppingApp.Model.Items.MeasurementState;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Model.Items.Produce
{
    public class Lemons : ItemEntity
    {
        public Lemons(Customer customer) : base(customer)
        {
            Price = .65;
            ItemName = "Lemons";
            ItemType = new ItemTypeState.Produce();
            MeasurementType = new Whole(this);
        }
    }
}
