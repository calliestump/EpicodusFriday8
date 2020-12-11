using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadRulesTests
  {
    [TestMethod]
    public void BreadRules_creates_BreadPrice()
    {
      
      Assert.AreEqual("5", Bread.BreadPrice);
    }
  }
}