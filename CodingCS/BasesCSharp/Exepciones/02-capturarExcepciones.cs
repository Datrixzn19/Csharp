//captura de varias excepciones 
using System;

namespace variasexepciones
{
    internal class VariasExcepciones
    {
        public static void ejercicio1()
        {
            int adivina =  4;
            int Minumero;
            Console.WriteLine("adivina el numero del 1 al 10");
//no hay limites de catchs
            do
            {
                try{
                Minumero = int.Parse(Console.ReadLine());
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("solo numeros");
                    Console.WriteLine("");
                    Minumero = 0;
                }
                catch(OverflowException ex)
                {
                    Console.WriteLine("numero muy grande o chico");
                    Console.WriteLine("");
                    Minumero = 0;
                }

                if(Minumero != adivina) Console.WriteLine("NO");
                
            }
            while(Minumero != adivina);
            {
                Console.WriteLine("ADIVINASTE");
            }


        }

    }
}