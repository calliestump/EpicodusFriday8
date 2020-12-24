using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTest
  {
    [TestMethod]
    public void Bread_createsBreadInstance_Bread()
    {
      Bread newBread = new Bread(5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
     public void BreadPrice_checksPriceOfBread_Bread()
    {
     int costOfBread = 20;
     int breadQuantity = 4;
     Bread newBread = new Bread(breadQuantity);
     int totalBreadCost = newBread.CostOfBread();
     Assert.AreEqual(costOfBread, totalBreadCost);
    }

    [TestMethod]
    public void BreadPrice_GetsOrderAfterDiscount_Int()
    {
      int breadQuantity = 1;
      Bread newBread = new Bread(breadQuantity);
      int result = newBread.CostOfBread();
      Assert.AreEqual(4, result);
    }
  }
}