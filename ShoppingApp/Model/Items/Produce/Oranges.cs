using ShoppingApp.Model.Items.MeasurementState;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Model.Items.Produce
{
    public class Oranges : ItemEntity
    {
        public Oranges(Customer customer) : base(customer)
        {
            Price = .9;
            ItemName = "Oranges";
            ItemType = new ItemTypeState.Produce();
            MeasurementType = new Whole(this);
        }
    }
}
