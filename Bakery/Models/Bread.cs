namespace Bakery.Models
{
  public class Bread
  {
    public int PriceOfBread { get; set; } = 5;
    public int QuantityOfBread { get; set; }
    public Bread(int breadQuantity)
    {
      QuantityOfBread = breadQuantity;
    }
    public int CostOfBread()
    {
      if (QuantityOfBread % 3 == 0)
      {
        int costOfBread = (QuantityOfBread - (QuantityOfBread /3)) * PriceOfBread;
        return costOfBread;
      }
      else
      {
        return PriceOfBread * QuantityOfBread;
      }
    }
  }
}