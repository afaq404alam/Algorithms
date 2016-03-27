using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PowerSet
{
  class Program
  {
    static void Main(string[] args)
    {
      var set = new[] {'a','b','c' };
      PrintPowerSet(set, set.Length);

      Console.ReadLine();
    }

    static void PrintPowerSet(char[] set, int setSize)
    {
      double powerSetSize = Math.Pow(2, setSize);
      for (int counter = 0; counter < powerSetSize; counter++)
      {
        for (int i = 0; i < setSize; i++)
        {
          if ((counter & (1 << i)) > 0)
          {
            Console.Write(set[i]);
          }
        }
        Console.Write("\n");
      }
    }
  }
}
