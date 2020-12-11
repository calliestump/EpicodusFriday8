namespace Bakery.Models
{
  public class Bread
  {
    public int _PriceOfBread { get; set; }
    public int _QuantityOfBread { get; set; }
    public Bread(int breadQuantity, int breadPrice)
    {
      _QuantityOfBread = breadQuantity;
      _PriceOfBread = breadPrice;
    }
    public int CostOfBread()
    {
      int costOfBread = _PriceOfBread * _QuantityOfBread;
      return costOfBread;
    }
  }
  public class Pastry
  {
    public int _PriceOfPastry { get; set; }
    public int _QuantityOfPastry {get; set; }
    public Pastry(int pastryQuantity, int pastryPrice)
    {
      _QuantityOfPastry = pastryQuantity;
      _PriceOfPastry = pastryPrice;
    }
    public int CostOfPastry()
    {
      int costOfpastry = _PriceOfPastry * _QuantityOfPastry;
      return costOfpastry;
    }
  }
}