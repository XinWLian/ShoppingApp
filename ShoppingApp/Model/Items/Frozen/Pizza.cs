using ShoppingApp.Model.Items.MeasurementState;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Model.Items.Frozen
{
    public class Pizza : ItemEntity
    {
        public Pizza(Customer customer) : base(customer)
        {
            Price = 5.7;
            ItemName = "Pizza";
            ItemType = new ItemTypeState.Frozen();
            MeasurementType = new Whole(this);
        }
    }
}
