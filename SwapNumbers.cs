using System;

class SwapNumbers
{
  public static void Main(string[] rags)
  {
    int num1, num2, holder;

    Console.WriteLine("Enter the first number");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the second number:> ");
    num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Numbers you have entered before swapping...");
    Console.WriteLine("First Number = {0}", num1);
    Console.WriteLine("Second Number = {0}", num2);

    void swapNumber(int a, int b)
    {
      holder = a;
      a = b;
      b = holder;
    }

    SwapNumbers(num1, num2);

    Console.WriteLine("Numbers you have entered after swapping....");
    Console.Write("First Number = {0}", num1);
    Console.WriteLine("Second Number = {0}", num2);
  }
}