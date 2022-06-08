using ShoppingApp.Model.Items.MeasurementState;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Model.Items.Beverage
{
    public class Milk : ItemEntity
    {
        public Milk(Customer customer) : base(customer)
        {
            Price = 3;
            ItemName = "Milk";
            ItemType = new ItemTypeState.Beverages();
            MeasurementType = new Whole(this);
        }
    }
}
