using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int PriceOfBread { get; }
    public int QuantityOfBread { get; }
    public Bread(int breadPrice, int breadQuantity)
    {
      PriceOfBread = breadPrice;
      QuantityOfBread = breadQuantity;
    }
  }
  public class Pastry
  {
    public int PriceOfPastry { get; }
    public int QuantityOfPastry {get; }
    public Pastry(int pastryprice, int pastryQuantity)
    {
      PriceOfPastry = pastryprice;
      QuantityOfPastry = pastryQuantity;
    }
  }
}