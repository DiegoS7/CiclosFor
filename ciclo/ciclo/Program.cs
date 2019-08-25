using System;

namespace ciclo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Indique el inicio y el final de su impresion de numeros.");
            Console.WriteLine();

            Console.WriteLine("Ingrese el Valor de X");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese el Valor de Y");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Indique de cuanto avanzará el ciclo");
            z = Convert.ToInt32(Console.ReadLine());

            if (x>y)//fghgfgfh
            {
                for (int i = x; i > y; i -= z)
                {
                    Console.WriteLine("i = " + i);
                }
            }
            else
            {
                for (int i = x; i < y; i += z)
                {
                    Console.WriteLine("i = " + i);
                }
            }

        }
    }
}
