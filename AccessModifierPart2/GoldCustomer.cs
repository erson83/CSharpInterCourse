namespace AccessModifiers

{
    public class GoldCustomer : Customer    //derived classes
    {
        public void OfferVoucher()
        {
            this.CalculateRating(excludeOrders: true);
            Console.WriteLine("offseting voucher");
        }
    }




}

