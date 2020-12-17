using System;
using Bakery.Models;
class Program
{
  static void Main()
  {
    // Menu Setup
    Console.WriteLine("");
    Console.WriteLine("Hello, Welcome to Pierre's Bakery!");
    Console.WriteLine("");
    Console.WriteLine("Menu");
    Console.WriteLine("-------");
    Console.WriteLine("Bread Loaf: $5");
    Console.WriteLine("Deals: Buy 2, get 1 free!");
    Console.WriteLine("");
    Console.WriteLine("Pastry's: $2");
    Console.WriteLine("Deals: 3 for $5");
    Console.WriteLine("");
    // Users Bread & Pastry Order
    Console.WriteLine("How many loaves of bread would you like?:");
    int breadQuantity = int.Parse(Console.ReadLine());
    Console.WriteLine("How many pastry's would you like?:");
    int pastryQuantity = int.Parse(Console.ReadLine());
    //Bread Prices
    Bread bread = new Bread(breadQuantity);
    Pastry pastry = new Pastry(pastryQuantity);
    if (breadQuantity == 2)
    {
      int discountBreadQuantity = breadQuantity + 1;
      Console.WriteLine($"Your cart comes to {discountBreadQuantity} loaves of bread & {pastryQuantity} pastry('s).");
    }
    else
    {
      Console.WriteLine($"Your cart comes to {breadQuantity} loaves of bread & {pastryQuantity} pastry('s).");
    }
    Console.WriteLine($"Cost of bread: ${bread.CostOfBread()}.00");
    Console.WriteLine($"Cost of pastry: ${pastry.CostOfPastry()}.00");
    Console.WriteLine($"Your total for your order is ${bread.CostOfBread() + pastry.CostOfPastry()}");
    Console.WriteLine("Thank you! Hope to see you again soon :)");
  }
}