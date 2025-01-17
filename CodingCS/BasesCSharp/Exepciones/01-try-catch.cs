using System;

namespace trycatch
{
    internal class Trycatch
    {

        public static void ejercicio1()
        {
            int adivina =  4;
            int Minumero;

            Console.WriteLine("adivina el numero del 1 al 10");
            //try = intenta
            //catch = captura 

            do
            {
                try{
                Minumero = int.Parse(Console.ReadLine());
                }
                catch(FormatException ex)//ex = error exception
                {
                    Console.WriteLine("ups, algo salio mal");
                    Minumero = 0;// se la inicia porque talvez en el try nunca
                    // se inicalize
                    // y en c# se deben inicializar las variables
                    //no es una buena forma de hacerlo 
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