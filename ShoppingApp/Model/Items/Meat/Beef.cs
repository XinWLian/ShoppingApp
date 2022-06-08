using ShoppingApp.Model.Items.MeasurementState;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Model.Items.Meat
{
    public class Beef : ItemEntity
    {
        public Beef(Customer customer) : base(customer)
        {
            Price = 7.6;
            ItemName = "Beef(lb)";
            ItemType = new ItemTypeState.Meat();
            MeasurementType = new Measured(this);
        }
    }
}
