using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadRules_createsBreadInstance_Bread()
    {
      Bread newBread = new Bread(5, 2);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void PastryRules_createsPastryInstance_Pastry()
    {
      Pastry newPastry = new Pastry(2,4);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
  }
}