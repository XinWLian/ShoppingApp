using ShoppingApp.Model.Items.MeasurementState;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Model.Items.Frozen
{
    public class Lasagna : ItemEntity
    {
        public Lasagna(Customer customer) : base(customer)
        {
            Price = 11.2;
            ItemName = "Lasagna";
            ItemType = new ItemTypeState.Frozen();
            MeasurementType = new Whole(this);
        }
    }
}
