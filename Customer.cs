﻿using System;
namespace CSharp_intermediate
{
	public class Customer
	{
		public int Id;
		public string Name;
		public List<Order> Orders;

		// declaing Constructors (include the default one)
		public Customer()
		{
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

