using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Exercicios.Exercicios
{
  internal class ex10
  {
  
    public void fileSize()
    {
      long length = new FileInfo("C:\\Users\\Thzin\\Desktop\\Lista-64Exercicios.pdf").Length;
      Console.WriteLine(length);
    }
  }
}
//Write a C# program to find the size of a specified file in bytes.