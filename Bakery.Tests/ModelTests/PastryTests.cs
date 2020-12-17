using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Pastry_createsPastryInstance_Pastry()
    {
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
     public void PastryPrice_checksPriceOfPastry_Pastry()
    {
     int pastryQuantity = 5;
     int pastryPrice = 2;
     Pastry newPastry = new Pastry(pastryQuantity);
     int totalPastryCost = newPastry.CostOfPastry();
     Assert.AreEqual(pastryPrice, totalPastryCost);
    }
  }
}