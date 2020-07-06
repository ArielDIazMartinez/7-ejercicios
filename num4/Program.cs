using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num4
{
    class Program
    {
		public static void Main()

		{
			/*      Un programa que almacene en una tabla el número de días que tiene cada 
             mes(supondremos que es un año no bisiesto), pida al usuario que le 
             indique un mes(1 = enero, 12 = diciembre) y muestre en pantalla el 
             número de días que tiene ese mes.   */


			int[] dias = new int[4];
			dias[1] = 31;
			dias[2] = 30;
			dias[3] = 28;

			int[] meses = new int[13];

			
			

			meses[1] = dias[1];
			meses[2] = dias[3];
			meses[3] = dias[1];
			meses[4] = dias[2];
			meses[5] = dias[1];
			meses[6] = dias[2];
			meses[7] = dias[1];
			meses[8] = dias[1];
			meses[9] = dias[2];
			meses[10] = dias[1];
			meses[11] = dias[2];
			meses[12] = dias[1];

			int mes = 0;
			Console.WriteLine("Ingrese el numero del mes ");

			mes = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("El mes {0} tiene {1} dias", mes, meses[mes]);


			Console.ReadKey();
		}
    }
}
