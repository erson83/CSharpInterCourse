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


}


