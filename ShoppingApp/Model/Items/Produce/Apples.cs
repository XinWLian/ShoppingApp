using ShoppingApp.Model.Items.MeasurementState;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Model.Items.Produce
{
    public class Apples:ItemEntity
    {
        public Apples(Customer customer) : base(customer)
        {
            Price = 1.3;
            ItemName = "Apples";
            ItemType = new ItemTypeState.Produce();
            MeasurementType = new Whole(this);
        }
    }
}
