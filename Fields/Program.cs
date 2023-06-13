namespace Fields

{

    // A quick way to create a constructor: type ctor and press tab. This is a code snippet.
    // A field can be initialized in two ways: In a constructor, or directly upon declaration. The
    // benefit of initialising a field during declaration is that if your class has one or more
    // constructors, you’ll make sure that the field will always be initialised irrespective of
    // which constructor is going to be called.

    class Program

    {

        static void Main(string[] args)
        {
            var customer = new Customer(1, "Jefferson");
            customer.Orders.Add(new Order(10001, "Ipad"));
            customer.Orders.Add(new Order(10002, "Imac"));

            // if we run the customer.Promote below, it will become zero if we accidentally
            // reintialize Orders = new List<Order>(); in Promote class
            //customer.Promote();
            Console.WriteLine(customer.Orders.Count);


            foreach (var item in customer.Orders)
            {
                Console.WriteLine(item.ItemId);
                Console.WriteLine(item.ProductName);
            }

        }


    }




}
