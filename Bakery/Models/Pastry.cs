namespace Bakery.Models
{
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
      int costOfpastry = PriceOfPastry * QuantityOfPastry;
      return costOfpastry;
    }
  }
}