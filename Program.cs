using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1411hw
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            //int i = 1;
            //while (i <= 2000)
            //{
            //    Console.WriteLine( i );
            //    i++;
            //}

            //for (int i = 1; i <= 2000; i++)
            //{
            //    Console.WriteLine( i );
            //}

            //for (int i = 2; i <= 100; i = i + 2)
            //{
            //    Console.WriteLine(i);
            //}


            //for (int i = 10; i <= 100; i = i + 10)
            //{
            //    Console.WriteLine(i);
            //}

            // 2
            //for (int i = 100; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            // 3
            int a = Convert.ToInt32(Console.ReadLine());

            // if has two digits? >=10 and <= 99
            if (a >= 10 && a <= 99) // for or do this ||
            {
                // has two digits

                // calc ahadot
                int ahadot = a % 10;
                Console.WriteLine("ahadot is: ");
                Console.WriteLine( ahadot );

                // calc ahadot
                int asarot = a / 10;
                Console.WriteLine("asarot is: ");
                Console.WriteLine(ahadot);

                if (asarot > ahadot)
                {
                    Console.WriteLine("Asarot is bigger !");
                }
                else if (asarot == ahadot)
                {
                    Console.WriteLine("Equal!");
                }
                else
                {
                    Console.WriteLine("Ahadot is bigger !");
                }
            }


        }
    }
}
