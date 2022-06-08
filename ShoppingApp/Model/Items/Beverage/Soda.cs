using ShoppingApp.Model.Items.MeasurementState;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Model.Items.Beverage
{
    public class Soda : ItemEntity
    {
        public Soda(Customer customer) : base(customer)
        {
            Price = 2.5;
            ItemName = "Soda(2 Liter)";
            ItemType = new ItemTypeState.Beverages();
            MeasurementType = new Whole(this);
        }
    }
}
