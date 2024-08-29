using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercicios.Exercicios
{
  //  Write a C# program to print odd numbers from 1 to 99. Prints one number per line.
  //Sample Output:
  //Odd numbers from 1 to 99. Prints one number per line.
  //1
  //3
  //5
  //7
  //9
  //...
  //95
  //97
  //99

  internal class ex7
  {
    public void printOddNumbersUntil99()
    {
      for (int i = 0; i <= 99; i++)
      {
        int count = i;
        if (count % 2 == 1)
        {
          int oddNumber = i;
          Console.WriteLine(oddNumber);
        }
      }
    }
  }
}
