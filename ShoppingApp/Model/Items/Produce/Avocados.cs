using ShoppingApp.Model.Items.MeasurementState;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Model.Items.Produce
{
    public class Avocados : ItemEntity
    {
        public Avocados(Customer customer) : base(customer)
        {
            Price = 1.86;
            ItemName = "Avocados";
            ItemType = new ItemTypeState.Produce();
            MeasurementType = new Whole(this);
        }
    }
}
