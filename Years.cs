using System;

namespace YearsOfSaving
{
  class Years
  {
    private double amount, annual_rate, target_amount, interest, years, compounded_amount, compounded_interest;

    public void datain()
    {
      Console.WriteLine("Enter amount of money deposited:> ");
      amount = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Enter the annual interest:> ");
      annual_rate = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Enter the target amount:> ");
      target_amount = Convert.ToDouble(Console.ReadLine());
    }

    public void calculate()
    {
      interest = target_amount - amount;

      years = Math.Log(interest) / (Math.Log(amount) * (1 + (annual_rate / 100)));

      compounded_interest = (amount * (1 + annual_rate));

      Math.Pow(compounded_interest, Math.Ceiling(years));

      compounded_amount = compounded_interest + amount;
    }

    public void output()
    {
      Console.WriteLine("It will take {0} years for your money to reach your target", Math.Ceiling(years));
      Console.WriteLine("The amount in your account will be {0}", compounded_amount);
    }
  }

  class YearsProgram
  {
    public static void Main(string[] args)
    {
      Years yr1 = new Years();
      Years yr2 = new Years();

      Console.WriteLine("Data entry for the first customer");
      Console.WriteLine("-----------------------------------");
      yr1.datain();
      Console.WriteLine("-----------------------------------");

      Console.WriteLine("Data entry for the second customer");
      Console.WriteLine("-----------------------------------");
      yr2.datain();

      Console.WriteLine("-----------------------------------");
      Console.WriteLine("Data output for the first customer");
      yr1.calculate();
      yr1.output();
      
      Console.WriteLine("-----------------------------------");
      Console.WriteLine("Data output for the second customer");
      yr2.calculate();
      yr2.output();
      Console.WriteLine("-----------------------------------");
    }

  }
}