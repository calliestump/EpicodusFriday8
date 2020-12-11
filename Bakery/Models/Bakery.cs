using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int PriceOfBread { get; set; }
    public int QuantityOfBread { get; set; }
    public Bread(int breadQuantity, int breadPrice)
    {
      QuantityOfBread = breadQuantity;
      PriceOfBread = breadPrice;
    }
    public int CostOfBread()
    {
      int costOfBread = PriceOfBread * QuantityOfBread;
      return costOfBread;
    }
  }
  public class Pastry
  {
    public int PriceOfPastry { get; set; }
    public int QuantityOfPastry {get; set; }
    public Pastry(int pastryQuantity, int pastryPrice)
    {
      QuantityOfPastry = pastryQuantity;
      PriceOfPastry = pastryPrice;
    }
    public int CostOfPastry()
    {
      int costOfpastry = PriceOfPastry* QuantityOfPastry;
      return costOfpastry;
    }
  }
}