using System;

namespace  buclewhile
{
    internal class Buclewhile
    {
        public static void ejercicio1()
        {

            Console.WriteLine("Hagamos un contador hasta 100, elije un numero base");
            int num = int.Parse(Console.ReadLine());

            while(num < 100)
            {
                Console.WriteLine($"El contador esta en: {num}");
                num++;
            }
                


        }
    }
}