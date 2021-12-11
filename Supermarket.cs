using System;

namespace MySupermarket
{
  class Supermarket
  {
    private int entries, i;
    private int[] quantities;
    private string[] codes;
    private double[] prices;
    private double[] total_prices;
    private double[] discounts;

    private double[] net_prices;

    public void getEntries()
    {
      Console.WriteLine("Enter the number of products you want to work with:> ");
      entries = Convert.ToInt32(Console.ReadLine());

      quantities = new int[entries];
      prices = new double[entries];
      codes = new string[entries];
      total_prices = new double[entries];
      discounts = new double[entries];
      net_prices = new double[entries];
    }

    public Supermarket(double price, double quantity, double total_cost)
    {
      prices[i] = price;
      quantities[i] = quantity;
      total_prices[i] = total_cost;
    }

    public Supermarket(double price, double quantity, double total_cost)
    {
      price = 0;
      quantity = 0;
      total_cost = 0;
    }

    public double Price
    {
      get
      {
        return prices[i];
      }

      set
      {
        prices[i] = value;
      }
    }

    public double Quantity
    {
      get
      {
        return quantities[i];
      }

      set
      {
        quantities[i] = value;
      }
    }

    public double TotalCost
    {
      get
      {
        return total_prices[i];
      }

      set
      {
        total_prices[i] = value;
      }
    }

    public string Code
    {
      set
      {
        prices[i] = value;
      }
    }

    public void input()
    {
      for (i = 0; i < entries; i++)
      {
        Console.WriteLine("Enter code for product {0}:> ", (i + 1));
        codes[i] = Console.ReadLine();
        Console.WriteLine("Enter the price for product {0}", (i + 1));
        prices[i] = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the quantity for product {0}", (i + 1));
        quantities[i] = Convert.ToInt32(Console.ReadLine());
      }
    }

    public void compute()
    {
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
    }

    public void output()
    {
      for (i = 0; i < entries; i++)
      {
        Console.WriteLine("Item Code = {0}    Price = {1}   Quantities = {2}    Discount = {3}    Total Price  = {4}    Net Price {5}", codes[i], prices[i], quantities[i], discounts[i], total_prices[i], net_prices[i]);
      }
    }
  }

  class SupermarketProgram
  {
    public static void Main(string[] args)
    {
      Supermarket super1 = new Supermarket();
      Console.WriteLine("Entry for super 1:>");
      Console.WriteLine("-------------------------------");
      super1.getEntries();

      Console.WriteLine("Product entries for super1:> ");
      Console.WriteLine("-------------------------------");
      super1.input();

      Console.WriteLine("Product output for duper 1:> ");
      Console.WriteLine("-------------------------------");
      super1.compute();
      super1.output();
    }
  }
}