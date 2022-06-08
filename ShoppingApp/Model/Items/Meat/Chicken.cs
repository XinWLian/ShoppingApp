using ShoppingApp.Model.Items.MeasurementState;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Model.Items.Meat
{
    public class Chicken: ItemEntity
    {
        public Chicken(Customer customer) : base(customer)
        {
            Price = 7.70;
            ItemName = "Chicken(Whole)";
            ItemType = new ItemTypeState.Meat();
            MeasurementType = new Whole(this);
        }
    }
}
