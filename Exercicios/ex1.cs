using System;

namespace Exercicios_csharp.Exercicios_pt1
{
  internal class ex1
  {
    // Method to swap two numbers
    void trocaValoresDePosicao(int valor1, int valor2)
    {
      // Temporary variable to hold the value of valor1
      int temp = valor1;

      // Swapping the values of valor1 and valor2
      valor1 = valor2;
      valor2 = temp;

      // Printing the swapped values
      Console.WriteLine("After Swapping :");
      Console.WriteLine($"First Number : {valor1}");
      Console.WriteLine($"Second Number : {valor2}");
    }

  //  static void Main(string[] args)
  //  {
  //    // Test data
  //    Console.WriteLine("Input the First Number : ");
  //    int num1 = Convert.ToInt32(Console.ReadLine());

  //    Console.WriteLine("Input the Second Number : ");
  //    int num2 = Convert.ToInt32(Console.ReadLine());

  //    // Creating an object of ex1 class
  //    ex1 obj = new ex1();

  //    // Calling the method to swap numbers
  //    obj.trocaValoresDePosicao(num1, num2);
  //  }
  }
}
