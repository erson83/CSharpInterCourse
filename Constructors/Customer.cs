using System;

namespace Constructors

// A constructor is a method that is called when an instance of a class is created
// As a best practice, define a constructor only when an object “needs” to be initialised
// Constructors do not have a return type, not even void, and they should have the exact
// same name as the class


{
    public class Customer
	{
		public int Id;
		public string Name;
        public int Age;
		public List<Order> Orders;

		// type ctor to create constructor

		public Customer()
        {
            // Orders has to be initialized here, otherwise it
            // will be a null reference. As a best practice,
            // anytime your class contains a list, always
            // initialize the list.
            Orders = new List<Order>();


		}

        public Customer(int id)
    // - Constructors can be overloaded. Overloading means creating a method with the same
    // name and different signatures.
    // Signature of a method consists of the number, type and order of its parameters.
    // it will call the previous public Customer() and copy over
    // otherwise, we have to copy and paste "Orders = new List<Order>();" onto all contsructors,
    // but using : this() will save code lines 
    // keep using : this() to a minimum

            : this()
        {
            // Orders = new List<Order>();
            this.Id = id;

        }

        public Customer(int id, string name)
            : this()
        {

            // Orders = new List<Order>();
            this.Id = id;
            this.Name = name;
        }

        public Customer(int id, string name, int age)
            :this(id, name)
        {

            // Orders = new List<Order>();
            // this.Id = id;
            // this.Name = name;
            this.Age = age;
        }

    }
}

