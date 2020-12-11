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
      Bread newBread = new Bread(5,3);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void Pastry_createsPastryInstance_Pastry()
    {
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
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
    [TestMethod]
     public void PastryPrice_checksPriceOfPastry_Pastry()
    {
     
    }
  }
}