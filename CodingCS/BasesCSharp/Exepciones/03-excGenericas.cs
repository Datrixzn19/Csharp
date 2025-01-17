using System;

namespace excgenericas 
{
    internal class ExcGenericas
    {

        public static void ejercicio1()
        {
            int adivina =  4;
            int Minumero;

            Console.WriteLine("adivina el numero del 1 al 10");


            do
            {
                try{
                Minumero = int.Parse(Console.ReadLine());
                }
                catch(Exception ex) //tienen gererquias
                //este recoge las exepciones de manera general
                //ex/e es un objeto con e.Message da info sobre la exception 
                {
                    Console.WriteLine(ex.Message);
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