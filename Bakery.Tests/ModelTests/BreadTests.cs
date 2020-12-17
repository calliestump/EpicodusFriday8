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
    // [TestMethod]
    //  public void BreadPrice_checksPriceOfBread_Bread()
    // {
    //  int breadPrice = 5;
    //  int breadQuantity = 4;
    //  //int total = 20;
    //  Bread newBread = new Bread(breadQuantity);
    //  int totalBreadCost = newBread.CostOfBread();
    //  Assert.AreEqual(totalBreadCost, breadPrice);
    // }
  }
}