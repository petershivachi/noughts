using System;

class NestedForLoops
{
  public static void Main(string[] args)
  {
    int i, j;

    for (i = 1; i <= 8; i++) {
      for(j = 1; j <= 9 - i; j++){
        Console.Write(j + " ");
      }
      Console.Write("\n");
     }
  }
}