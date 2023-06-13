namespace Testability

{
    // This code defines a class named ShippingCalculator that calculates the shipping cost based on
    // the total price of an order. If the total price is less than 30, the shipping cost is calculated
    // as 10% of the total price; otherwise, the shipping cost is 0.
    public interface IShippingCalculator // added this new interface
    {
        float CalculateShipping(Order order);
        // take note of the ;
    }

    public class ShippingCalculator : IShippingCalculator // added : IShippingCalculator
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


}


