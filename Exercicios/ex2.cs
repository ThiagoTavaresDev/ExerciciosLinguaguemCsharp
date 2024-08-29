using System;

//Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user.
//Test Data:
//Input the first number: 25
//Input the second number: 4
//Expected Output:
//25 + 4 = 29
//25 - 4 = 21
//25 x 4 = 100
//25 / 4 = 6
//25 mod 4 = 1

namespace Exercicios.Exercicios
{
  internal class ex2
  {
    double soma(double val1, double val2)
    {
      Console.WriteLine($"a soma é: {val1 + val2}");
      return val1 + val2;
    }
    double subtracao(double val1, double val2)
    {
      Console.WriteLine($"a subtracao é: {val1 - val2}");
      return val2 - val1;
    }
    double multiplicacao(double val1, double val2)
    {
      Console.WriteLine($"a multiplicacao é: {val1 * val2}");
      return val1 * val2;
    }
    double divisao(double val1, double val2)
    {
      Console.WriteLine($"a divisao é: {val1 / val2}");
      return val1 / val2;
    }
    double modulo(double val1, double val2)
    {
      Console.WriteLine($"o modulo é: {val1 % val2}");
      return val1 % val2;
    }

    //  static void Main(String[] args)
    //  {
    //    ex2 obj = new ex2();

    //    Console.WriteLine("Digite o primeiro valor");
    //    double numero1 = double.Parse(Console.ReadLine());
    //    Console.WriteLine("Digite o segundo valor");
    //    double numero2 = double.Parse(Console.ReadLine());
    //    obj.soma(numero1, numero2);
    //    obj.subtracao(numero1, numero2);
    //    obj.multiplicacao(numero1, numero2);
    //    obj.divisao(numero1, numero2);
    //    obj.modulo(numero1, numero2);

    //  }
  }
}
