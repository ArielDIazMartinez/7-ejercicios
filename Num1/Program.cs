using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Un programa que pida al usuario 4 números, los memorice(utilizando una tabla), 
             calcule su media aritmética y después muestre en pantalla la media y los datos tecleados. */

            int[] numeros = new int[4];
            double Media;

            for (int Datos = 0; Datos <= 3; Datos++)                                  
            {
                Console.Write("Introduce los valores numericos {0}: ", Datos + 1);
                numeros[Datos] = Convert.ToInt32(Console.ReadLine());
            }

            Media = 0;


            for (int i = 0; i <= 3; i++)
            {
                Media = Media + numeros  [i];
       
            }

            Media = Media / 4;


            Console.WriteLine("Su Media es {0}", Media);


            Console.ReadKey();




        }

        

    }
}
