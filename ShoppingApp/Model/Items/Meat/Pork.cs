using ShoppingApp.Model.Items.MeasurementState;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Model.Items.Meat
{
    public class Pork:ItemEntity
    {
        public Pork(Customer customer) : base(customer)
        {
            Price = 3.2;
            ItemName = "Pork";
            ItemType = new ItemTypeState.Meat();
            MeasurementType = new Measured(this);
        }
    }
}
