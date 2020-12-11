using System;

namespace Bakery
{
  public class Bread
  {
    public string BreadPrice { get; set; }
    public Bread(string breadprice)
    {
      BreadPrice = breadprice;
    }
  }
  public class Pastry
  {
    public string PastryPrice { get; set; }
    public Pastry(string pastryprice)
    {
      PastryPrice = pastryprice;
    }
  }
}