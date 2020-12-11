using System;

namespace Bakery
{
  public class BreadRules
  {
    public string BreadPrice { get; set; }

    public BreadRules(string breadprice)
    {
      BreadPrice = breadprice;
    }
  }
}