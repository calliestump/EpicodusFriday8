using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Bread_createsBreadInstance_Bread()
    {
      Bread newBread = new Bread(5,4);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
     public void BreadPrice_checksPriceOfBread_Bread()
    {
     int breadPrice = 5;
     int breadQuantity = 4;
     int total = 20;
     Bread newBread = new Bread(breadQuantity, breadPrice);
     int totalBreadCost = newBread.CostOfBread();
     Assert.AreEqual(totalBreadCost, total);
    }
  }
  [TestClass]
  public class PastryTest
  {
    [TestMethod]
    public void Pastry_createsPastryInstance_Pastry()
    {
      Pastry newPastry = new Pastry(2,5);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
     public void PastryPrice_checksPriceOfPastry_Pastry()
    {
     int pastryPrice = 2;
     int pastryQuantity = 5;
     int total = 10;
     Pastry newPastry = new Pastry(pastryQuantity, pastryPrice);
     int totalPastryCost = newPastry.CostOfPastry();
     Assert.AreEqual(totalPastryCost, total);
    }
  }
}