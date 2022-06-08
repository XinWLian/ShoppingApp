using ShoppingApp.Model.Items;
using ShoppingApp.Model.Items.Beverage;
using ShoppingApp.Model.Items.Frozen;
using ShoppingApp.Model.Items.Meat;
using ShoppingApp.Model.Items.Produce;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Model
{
    public class Customer
    {
        public Customer _customer;
        public List<ItemEntity> Item = new List<ItemEntity>();
        public double Total;
        public Customer()
        {
            Total = 0;
            //produce
            Item.Add(new Apples(this));
            Item.Add(new Avocados(this));
            Item.Add(new Bananas(this));
            Item.Add(new Lemons(this));
            Item.Add(new Lettuce(this));
            Item.Add(new Oranges(this));
            Item.Add(new Pineapple(this));
            Item.Add(new Strawberries(this));
            //meat
            Item.Add(new Beef(this));
            Item.Add(new Chicken(this));
            Item.Add(new Pork(this));
            //frozen
            Item.Add(new IceCream(this));
            Item.Add(new Lasagna(this));
            Item.Add(new Pizza(this));
            //Beverages
            Item.Add(new Milk(this));
            Item.Add(new Soda(this));

            _customer = this;
        }
        public void UpdateTotal(double before, double after)
        {
            Total = (Total - before) + after;
            OnTotalChanged();
        }
        public event Action TotalChanged;
        protected void OnTotalChanged()
        {
            TotalChanged?.Invoke();
        }
    }
}
