using System;
using System.Collections.Generic;

namespace OrderManagementSystem
{
    public class Order
    {
        // we use quick get set if we are not editing any of the variables here or worried about the sequence of declaring them
        // use this when eg. you do not need to worry about OrderId being changed using some rules etc.
        // we use the standard delcare intialize if we need to change the variable settings
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public double TotalAmount { get; set; }
    }

    public class OrderManager
    {
        private List<Order> orders;

        public OrderManager()
        {
            orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public void RemoveOrder(Order order)
        {
            orders.Remove(order);
        }

        public List<Order> GetAllOrders()
        {
            return orders;
        }
    }

    public class CustomerDetails
    {
        public string CustomerName;
        public string Salutation;
        public int Age;

        public CustomerDetails(string customerName, string salutation, int age)
        {
            this.CustomerName = customerName;
            this.Salutation = salutation;
            this.Age = age;

        }
    }


    public class CustomerList
    {
        // declare variable 
        private List<CustomerDetails> _customerDetails;


        // intialize list
        public CustomerList()
        {
            _customerDetails = new List<CustomerDetails>();
        }

        public void AddRecords(CustomerDetails customerDetails)
        {
            _customerDetails.Add(customerDetails);
            Console.WriteLine("Adding records for: " + customerDetails.CustomerName);
        }

        public List<CustomerDetails> DisplayAllRecords()
        {
            return _customerDetails;
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            // new OrderManager as new Order {} == new List<Order>()
            var orderManager = new OrderManager();

            // over here we use Array {}
            // we did not intialize the order, actually can be in any order result will be the same
            var order1 = new Order { OrderId = 1, OrderDate = DateTime.Now, CustomerName = "John Doe", TotalAmount = 100.00 };
            orderManager.AddOrder(order1);
            var order2 = new Order { OrderId = 2, OrderDate = DateTime.Now, TotalAmount = 200.00 , CustomerName = "Jane Doe" };
            orderManager.AddOrder(order2);

            List<Order> orders = orderManager.GetAllOrders();

            Console.WriteLine("Orders:");
            foreach (Order order in orders)
            {
                Console.WriteLine("Order ID: {0}, Order Date: {1}, Customer Name: {2}, Total Amount: {3}", order.OrderId, order.OrderDate, order.CustomerName, order.TotalAmount);
            }



            var customerList = new CustomerList();

            //over here we use () , look at how we use constructors to intialize the CustomerDetails
            var customerDetails1 = new CustomerDetails ("Jefferson","Mr",29 );
            customerList.AddRecords(customerDetails1);
            var customerDetails2 = new CustomerDetails ( "Ng Phang", "Mdm", 23 );
            customerList.AddRecords(customerDetails2);

            var showAllRecordsList = customerList.DisplayAllRecords();

            foreach (var cust in showAllRecordsList)
            {
                Console.WriteLine("Name {0} Salutation {1} Age {2}", cust.CustomerName, cust.Salutation, cust.Age);
            }

        }
    }
}
