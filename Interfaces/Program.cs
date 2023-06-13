using System;

namespace Testability

{

    // This code defines a class named Order. It represents an order and has properties such as Id, DatePlaced,
    // Shipment, and TotalPrice. The IsShipped property is a read-only property that returns true if the Shipment
    // property is not null, indicating whether the order has been shipped.
    public class Order
    {
        public int Id { get; set; }
        public DateTime DatePlaced { get; set; }
        public Shipment Shipment { get; set; }
        public float TotalPrice { get; set; }

        public bool IsShipped
        {
            get { return Shipment != null; }
        }


    }


    // This code defines a class named Shipment, representing a shipment associated with an order.
    // It has properties such as Cost and ShippingDate.
    public class Shipment
    {
        public float Cost { get; set; }
        public DateTime ShippingDate { get; set; }
    }

    // This code defines a class named ShippingCalculator that calculates the shipping cost based on
    // the total price of an order. If the total price is less than 30, the shipping cost is calculated
    // as 10% of the total price; otherwise, the shipping cost is 0.
    public class ShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
            {
                return order.TotalPrice * 0.1f;
            }
            else
            {
                return 0;
            }
        }

    }

    //This code defines a class named OrderProcessor that processes orders. It has a dependency on the ShippingCalculator class.
    //The Process method takes an Order as a parameter. If the order is already shipped (determined by the IsShipped property),
    //an exception is thrown. Otherwise, a new Shipment is created with its Cost calculated using the ShippingCalculator and
    //the ShippingDate set to tomorrow.


    public class OrderProcessor
    {
        // declare variables

        private readonly ShippingCalculator _shippingCalculator;

        // intialize variables

        public OrderProcessor()
        {
            this._shippingCalculator = new ShippingCalculator();
        }

        // call method

        public void Process(Order order)
        {
            if (order.IsShipped)
            {
                throw new InvalidOperationException("this order is already processed");
            }

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };

        }

    }



    class Program

    {
        static void Main(string[] args)
        {
            // This code represents the entry point of the program. It creates an instance of the OrderProcessor
            // class and an instance of the Order class. The Process method of OrderProcessor is called,
            // passing in the order object.
            var orderProcessor = new OrderProcessor();
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);

           //  orderProcessor.Process(new Order { DatePlaced = DateTime.Now, TotalPrice = 100f });   

        }
    }


}


