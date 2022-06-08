using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Model.Items.MeasurementState
{
    public interface IMeasurementType
    {
        void Increment();
        void Decrement();
    }
}
