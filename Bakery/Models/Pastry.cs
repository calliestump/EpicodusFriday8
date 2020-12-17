namespace Bakery.Models
{
  public class Pastry
  {
    public int PriceOfPastry { get; set; } = 2;
    public int QuantityOfPastry {get; set; }
    public Pastry(int pastryQuantity)
    {
      QuantityOfPastry = pastryQuantity;
    }
    public int CostOfPastry()
    {
      if (QuantityOfPastry % 3 == 0)
      {
        int costOfpastry = (QuantityOfPastry / 3) * 5;
        return costOfpastry;
      }
      else if (QuantityOfPastry % 3 > 0 && QuantityOfPastry > 3)
      {
        int costOfpastry = ((QuantityOfPastry / 3) * 5) + ((QuantityOfPastry % 3) * PriceOfPastry);
        return costOfpastry;
      }
      else
      {
        return QuantityOfPastry * PriceOfPastry;
      }
    }
  }
}