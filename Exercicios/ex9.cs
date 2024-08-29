using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Exercicios
{
  internal class ex9
  {
    public void sumOfDigitsByInputNumber()
    {
      int number = Convert.ToInt32(Console.ReadLine());
      int sum = 0;
        while (number != 0)
        {
          sum += number % 10;
          number /= 10;
        }
        Console.WriteLine("Sum of the digits of the said integer: " + sum);
    }
  }
}
//Write a C# program and compute the sum of an integer's digits.
//Sample Output:
//Input a number(integer): 12
//Sum of the digits of the said integer: 3