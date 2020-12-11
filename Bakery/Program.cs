using System;
using System.Collections.Generic;
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
    // Bread Price Calculation
    Console.WriteLine("How many loaves of bread would you like?:");
    string breadQuantity = Console.ReadLine();
    string breadPrice = "5";
    Bread newBread = new Bread(int.Parse(breadQuantity), int.Parse(breadPrice));
    int totalBreadCost = newBread.CostOfBread();
    Console.WriteLine(totalBreadCost);
    // Pastry Price Calculation
    Console.WriteLine("How many pastry's would you like?:");
    string pastryQuantity = Console.ReadLine();
    string pastryPrice = "2";
    Pastry newPastry = new Pastry(int.Parse(pastryQuantity), int.Parse(pastryPrice));
    int totalPastryCost = newPastry.CostOfPastry();
    Console.WriteLine(totalPastryCost);
    // Total price before deals.
    int billTotal = (totalPastryCost + totalBreadCost);
    Console.WriteLine("Your total is:");
    Console.WriteLine(billTotal);
  }
}