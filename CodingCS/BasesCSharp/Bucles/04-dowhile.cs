using System;

namespace dowhile
{
    internal class Dowhile
    {

        public static void ejercicio1()
        {
            int adivina =  4;
            int Minumero;

            Console.WriteLine("adivina el numero del 1 al 10");
            
            do
            {
                
                Minumero = int.Parse(Console.ReadLine());
                if(Minumero != adivina) Console.WriteLine("NO");
                
            }while(Minumero != adivina);
            {
                Console.WriteLine("ADIVINASTE");
            }


        }

    }
}