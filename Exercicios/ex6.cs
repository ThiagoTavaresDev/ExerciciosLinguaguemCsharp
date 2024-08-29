using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Exercicios
{
  internal class ex6
  {
  //Write a C# program to find the longest word in a string.
  //Test Data: Write a C# Sharp Program to display the following pattern using the alphabet.
  //Sample Output:
  //following
  public string findLongestWord()
    {
      string example = "Write a C# Sharp Program to display the following pattern using the alphabet.";
      string[] arrayString = example.Split(' ');

      var stringResultante = "";

      for (int i = 0; i < arrayString.Length; i++)
      {

        if (arrayString[i].Length > stringResultante.Length)
        {
          stringResultante =  arrayString[i];
        }
      }
      return stringResultante;
    }
  }
}
