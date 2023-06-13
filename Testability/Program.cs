using System;

namespace Testability

{


    class Program

    {
        static void Main(string[] args)
        {
            // This code represents the entry point of the program. It creates an instance of the OrderProcessor
            // class and an instance of the Order class. The Process method of OrderProcessor is called,
            // passing in the order object.
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);

            //  orderProcessor.Process(new Order { DatePlaced = DateTime.Now, TotalPrice = 100f });   

        }
    }


}


