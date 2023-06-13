namespace Testability

{
    //This code defines a class named OrderProcessor that processes orders. It has a dependency on the ShippingCalculator class.
    //The Process method takes an Order as a parameter. If the order is already shipped (determined by the IsShipped property),
    //an exception is thrown. Otherwise, a new Shipment is created with its Cost calculated using the ShippingCalculator and
    //the ShippingDate set to tomorrow.


    public class OrderProcessor
    {
        // declare variables

        private readonly IShippingCalculator _shippingCalculator;   //changed ShippingCalculator to ISHippingCalculator

        // intialize variables

        public OrderProcessor(IShippingCalculator shippingCalulator)    //added in IShippingCalculator shippingCalulator inside brackets
        {
            this._shippingCalculator = shippingCalulator;  // replaced new ShippingCalculator;
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


}


