using System;

namespace Testability

    //check out PropertiesPArt4(Nested)

{

    public class Order
    {
        public DateTime DatePlaced { get; set; }
        public Shipment Shipment { get; set; } // by getting TotalPrice, we can calculate shipment cost
        public float TotalPrice { get; set; }

    }

    public class Shipment // declare Shipment variables to calculate shipment cost
    {
        public float Cost { get; set; }
        public DateTime ShippingDate { get; set; }
    }



    public class ShippingCalculator // method used to calculate total price
    {
        public float CalculateShipping(Order order) //  takes an Order object as a parameter and returns a float value representing the calculated shipping cost.
        {
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

    }


    public class OrderProcessor // declare, initialize Process method
    {
        private readonly ShippingCalculator _shippingCalculator;

        public OrderProcessor()
        {
            this._shippingCalculator = new ShippingCalculator();
        }

        public void Process(Order order) // the order shipment details will be updated based on calculated shipping cost and date
            // invoke ShippingCalculator method
        {
            order.Shipment = new Shipment
                {
                    Cost = _shippingCalculator.CalculateShipping(order), // calling CalculateShipping method, pass in order
                    // passing in from Main (var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };)
                    ShippingDate = DateTime.Today.AddDays(1) // calculated by adding one more day
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


