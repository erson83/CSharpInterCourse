namespace AccessModifiers

{

    class Program

    {

        static void Main(string[] args)
        {

            var customer = new Customer();
            customer.Promote();
            // var rating = customer.CalculateRating();
            // Console.WriteLine("Returned CalculateRating: "+ rating);
            var goldCustomer = new GoldCustomer();
            goldCustomer.OfferVoucher();

        }


    }




}

