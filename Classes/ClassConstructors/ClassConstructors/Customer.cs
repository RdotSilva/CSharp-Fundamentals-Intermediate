﻿using System.Collections.Generic;

namespace ClassConstructors
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            // Always initialize list to empty list inside of constructor.
            Orders = new List<Order>();
        }
        public Customer(int id)
            : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
    }
}