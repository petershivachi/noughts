using System;

class SupermarketTwo
{
  public static void Main(string[] args)
  {
    string[] codes;
    int[] quantities;
    double[] prices, total_prices, discounts, net_prices;
    int entries, i;

    Console.WriteLine("Enter the number of products you want to work with:> ");
    entries = Convert.ToInt32(Console.ReadLine());

    quantities = new int[entries];
    prices = new double[entries];
    codes = new string[entries];
    total_prices = new double[entries];
    discounts = new double[entries];
    net_prices = new double[entries];

    for (i = 0; i < entries; i++)
    {
      Console.WriteLine("Enter code for product {0}:> ", (i + 1));
      codes[i] = Console.ReadLine();
      Console.WriteLine("Enter the price for product {0}", (i + 1));
      prices[i] = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Enter the quantity for product {0}", (i + 1));
      quantities[i] = Convert.ToInt32(Console.ReadLine());
    }

    for (i = 0; i < entries; i++)
    {
      total_prices[i] = quantities[i] * prices[i];
    }

    for (i = 0; i < entries; i++)
    {
      if (total_prices[i] > 20000)
      {
        discounts[i] = total_prices[i] * (20 / 100);
      }
      else if ((total_prices[i] > 10000 && total_prices[i] < 20000))
      {
        discounts[i] = total_prices[i] * (10 / 100);
      }
      else
      {
        discounts[i] = 0;
      }
    }

    for (i = 0; i < entries; i++)
    {
      net_prices[i] = total_prices[i] - discounts[i];
    }

    for (i = 0; i < entries; i++)
    {
      Console.WriteLine("Item Code = {0}    Price = {1}   Quantities = {2}    Discount = {3}    Total Price  = {4}    Net Price {5}", codes[i], prices[i], quantities[i], discounts[i], total_prices[i], net_prices[i]);
    }
  }
}