using ShoppingApp.Model.Items.MeasurementState;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Model.Items.Produce
{
    public class Strawberries : ItemEntity
    {
        public Strawberries(Customer customer) : base(customer)
        {
            Price = 2.1;
            ItemType = new ItemTypeState.Produce();
            ItemName = "Strawberries(lbs)";
            MeasurementType = new Measured(this);
        }
    }
}
