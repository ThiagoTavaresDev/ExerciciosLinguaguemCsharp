using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Exercicios
{
  internal class ex8
  {
    public void SumOfFirst500PrimeNumbers()
    {
      int quantityOfNumbers = 500; // Precisamos de 500 números primos
      int currentNumber = 2; // Começamos do 2, pois é o primeiro número primo
      int sum = 0; // Variável para armazenar a soma dos números primos encontrados
      int count = 0; // Contador de números primos encontrados

      while (count < quantityOfNumbers)
      {
        if (IsPrime(currentNumber))
        {
          sum += currentNumber; // Soma o número primo encontrado
          count++; // Incrementa o contador de números primos
        }
        currentNumber++; // Verifica o próximo número
      }

      Console.WriteLine("Sum of the first 500 prime numbers:");
      Console.WriteLine(sum); // Exibe a soma dos primeiros 500 números primos
    }

    private bool IsPrime(int number)
    {
      if (number <= 1)
        return false;

      for (int i = 2; i <= Math.Sqrt(number); i++)
      {
        if (number % i == 0)
          return false;
      }

      return true;
    }

  }
}
//Write a C# program to compute the sum of the first 500 prime numbers.
//Sample Output:
//Sum of the first 500 prime numbers:
//824693