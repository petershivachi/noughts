using System;

namespace ArrayCode
{
  class MyArray
  {
    private int i, entries, value;
    private int[] numbers;

    public void getEntries()
    {
      Console.WriteLine("Enter the number of entries you want to work with:> ");
      entries = Convert.ToInt32(Console.ReadLine());
      numbers = new int[entries];
    }

    public void getEven()
    {
      for (i = 0; i < entries; i++)
      {
        Console.WriteLine("Input for entry {0}", i + 1);
        numbers[i] = Convert.ToInt32(Console.ReadLine());
      }

      for (i = 0; i < entries; i++)
      {
        if (numbers[i] % 2 == 0)
        {
          value = 1;
          Console.WriteLine("{0} is an even number", i);
        }else {
          value = 0;
          Console.WriteLine("{0} is an odd number", i);
        }
      }
    }


  }

  class ArrayProgram
  {
    public static void Main(string[] args)
    {
      MyArray array1 = new MyArray();

      array1.getEntries();

      array1.getEven();
    }
  }
}

