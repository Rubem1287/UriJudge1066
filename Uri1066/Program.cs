using System;

namespace Uri1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, f, cont, cont1, cont2, cont3;


            cont = 0;
            cont1 = 0;
            cont2 = 0;
            cont3 = 0;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());


            if (a % 2 == 0)
            {

                cont += +1;
            }
            else
            {
                cont1 += +1;
            }


            if (b % 2 == 0)
            {

                cont += +1;
            }
            else
            {
                cont1 += +1;
            }


            if (c % 2 == 0)
            {
                cont += +1;
            }
            else
            {
                cont1 += +1;
            }


            if (d % 2 == 0)
            {

                cont += +1;
            }
            else
            {
                cont1 += +1;
            }


            if (e % 2 == 0)
            {

                cont += +1;
            }
            else
            {
                cont1 += +1;
            }

            //<------------------------------------------------------------------------------------> 

            if (a > 0)
            {

                cont2 += +1;
            }
            else if (a != 0 && a < 0)
            {

                cont3 += +1;
            }


            if (b > 0 && b != 0)
            {

                cont2 += +1;
            }
            else if (b != 0 && b < 0)
            {

                cont3 += +1;
            }


            if (c > 0 && c != 0)
            {

                cont2 += +1;
            }
            else if (c != 0 && c < 0)
            {

                cont3 += +1;
            }


            if (d > 0 && d != 0)
            {

                cont2 += +1;
            }
            else if (d != 0 && d < 0)
            {

                cont3 += +1;
            }


            if (e > 0 && e != 0)
            {

                cont2 += +1;
            }
            else if (e != 0 && e < 0)
            {

                cont3 += +1;
            }




            Console.WriteLine();
            Console.WriteLine(cont + " Valores par(es)");
            Console.WriteLine();
            Console.WriteLine(cont1 + " Valores impar(es)");
            Console.WriteLine();
            Console.WriteLine(cont2 + " Valores positivo(s)");
            Console.WriteLine();
            Console.WriteLine(cont3 + " Valores negativo(s)");
        }
    }
}
