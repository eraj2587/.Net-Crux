using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
      class Triangle
      {
          public void Draw(int number)
          {
              Console.WriteLine();
              for (int i = 0; i < number; i++)
              {
                  for (int j = 0; j<i+1; j++)
                  {
                      Console.Write("*");
                  }
                  Console.WriteLine();
              }
          }
      }
}



