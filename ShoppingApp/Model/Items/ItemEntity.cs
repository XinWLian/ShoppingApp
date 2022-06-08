using ShoppingApp.Model.Items.ItemTypeState;
using ShoppingApp.Model.Items.MeasurementState;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Model.Items
{
    public abstract class ItemEntity
    {
        public string ItemName;
        public double Price;
        public double Quantity;
        public double Total;
        public IItemType ItemType;
        public IMeasurementType MeasurementType;
        public Customer _customer;
        public ItemEntity(Customer customer)
        {
            Quantity = 0;
            Total = 0;
            _customer = customer;
        }
        public void UpdateTotal()
        {
            Total = Price * Quantity;
        }
        public void Increment()
        {
            double before = Total;
            MeasurementType.Increment();
            UpdateTotal();
            double after = Total;
            _customer.UpdateTotal(before, after);
            OnQuantityChanged();
        }
        public void Decrement()
        {
            double before = Total;
            MeasurementType.Decrement();
            UpdateTotal();
            double after = Total;
            _customer.UpdateTotal(before, after);
            OnQuantityChanged();

        }
        public event Action QuantityChanged;
        protected void OnQuantityChanged()
        {
            QuantityChanged?.Invoke();
        }
    }
}
