using System;

class Numbers
{

  public static void Main(string[] args)
  {
    int entries, i;
    int[] numbers;

    Console.WriteLine("Enter the numbers you want to work with:> ");
    entries = Convert.ToInt32(Console.ReadLine());

    numbers = new int[entries];

    for(i = 0; i < entries; i++){
      Console.WriteLine("Entry {0} :> ",(i + 1));
      numbers[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("Before sorting...");
    for(i = 0; i < entries; i++){
      Console.WriteLine("{0}",numbers[i]);
    }

    Array.Sort(numbers);

    Console.WriteLine("After sorting...");
    for(i = 0; i < entries; i++){
      Console.WriteLine("{0}",numbers[i]);
    }
  }
}