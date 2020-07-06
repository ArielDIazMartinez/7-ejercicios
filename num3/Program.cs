using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num3
{
    class Program
    {
        static void Main(string[] args)
        {
            //        Un programa que almacene los días de la semana en un array y luego mostrarlo.


            string[] nombres = { "Lunes", "Martes", "Miercoles","Jueves","Viernes","Sabado","Domingo" };

            for (int i = 0; i < nombres.Length; i++)

            {

                Console.WriteLine("Elemento {0}: {1}", i, nombres[i]);

            }



           



            Console.ReadKey();
        }
    }
}
