using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Testability.UnitTests;

[TestClass]
public class OrderProcessorTests
{
    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void Process_OrderIsAlreadyShipped_ThrowsAnException() //METHODNAME_CONDITION_EXCEPTIONMSG
    {

        var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
        var order = new Order
        {
            Shipment = new Shipment()   //this will pass a non-empty order to Order class
        };
    }

    [TestMethod]
    public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyoftheOrder()
    {
        var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
        var order = new Order();
        Assert.IsTrue(order.IsShipped);
        Assert.AreEqual(1,order.Shipment.Cost);
        Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);

    }



}


public class FakeShippingCalculator : IShippingCalculator
{
    public float CalculateShipping(Order order)
    {
        return 1;
    }
}