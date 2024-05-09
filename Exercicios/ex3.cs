using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

//Write a C# Sharp program that takes four numbers as input to calculate and print the average.
//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the third number: 20
//Enter the four number: 30

//Expected Output:
//The average of 10 , 15 , 20 , 30 is: 18
namespace Exercicios.Exercicios
{
  internal class ex3
  {
    static List<double> Valores = new();

   
    static void TiraMedia()
    {
      double tamanho = Valores.Count;
      double soma = Valores.Sum(x => x);
      double resultado = soma / tamanho;
            Console.WriteLine($"A média é: {resultado}");
     }
    static void Main(String[] args)
    {
      Console.WriteLine("Quanto valores voce deseja digitar?");
      int quantidade = int.Parse(Console.ReadLine());

      for (int i = 0; i < quantidade; i++)
      {
        Console.WriteLine($"Digite o {i + 1}º valor:");
        Valores.Add(double.Parse(Console.ReadLine()));
      }
      TiraMedia();
    }
    
  }  
}
