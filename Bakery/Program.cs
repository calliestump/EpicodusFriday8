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
    // Users Bread & Pastry Order
    Console.WriteLine("How many loaves of bread would you like?:");
    string breadQuantity = Console.ReadLine();
    Console.WriteLine("How many pastry's would you like?:");
    string pastryQuantity = Console.ReadLine();
    //Bread Prices
    string breadPrice = "5";
    Bread newBread = new Bread(int.Parse(breadQuantity), int.Parse(breadPrice));
    int totalBreadCost = newBread.CostOfBread();
    //Pastry Prices
    string pastryPrice = "2";
    Pastry newPastry = new Pastry(int.Parse(pastryQuantity), int.Parse(pastryPrice));
    int totalPastryCost = newPastry.CostOfPastry();
    // Total price with deals.
    int numBreadQuan = int.Parse(breadQuantity); //Parsing line 22
    int numPastryQuan = int.Parse(pastryQuantity); //Parsing line 24
    if (numBreadQuan == 0 && numPastryQuan == 0){
      Console.WriteLine("Oops! Please enter a valid order.");
      Program.Main();
    }
    if (numBreadQuan == 2 && numPastryQuan == 3) {
      numBreadQuan = 3;
      int newPastryCost = 5;
      Console.WriteLine($"Cost of bread: ${totalBreadCost}.00");
      Console.WriteLine($"Cost of pastry: ${newPastryCost}.00");
      int finalBill = totalBreadCost + newPastryCost;
      Console.WriteLine($"Your order total with todays deal is: ${finalBill}.00");
    }
    else if (numBreadQuan == 2 ) {
      numBreadQuan = 3;
      Console.WriteLine($"Cost of bread: ${totalBreadCost}.00");
      Console.WriteLine($"Cost of pastry: ${totalPastryCost}.00");
      int finalBill = totalBreadCost + totalPastryCost;
      Console.WriteLine($"Your order total with todays deal is: ${finalBill}.00");
    }
    else if (numPastryQuan == 3) {
      int newPastryCost = 5;
      Console.WriteLine($"Cost of bread: ${totalBreadCost}.00");
      Console.WriteLine($"Cost of pastry: ${newPastryCost}.00");
      int finalBill = totalBreadCost + newPastryCost;
      Console.WriteLine($"Your order total with todays deal is: ${finalBill}.00");
    } 
    else
    {
      Console.WriteLine($"Cost of bread: ${totalBreadCost}.00");
      Console.WriteLine($"Cost of pastry: ${totalPastryCost}.00");
      int finalBill = totalBreadCost + totalPastryCost;
      Console.WriteLine($"Your order total with todays deal is: ${finalBill}.00");
    }
    Console.WriteLine($"Your cart comes to {numBreadQuan} loaves of bread and {pastryQuantity} pastry's.");
    Console.WriteLine("Thank you! Hope to see you again soon :)");
  }
}