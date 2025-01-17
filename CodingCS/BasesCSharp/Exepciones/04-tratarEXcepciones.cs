// lo que se busca es capturar todas las excepciones de manera general pero a alguna no
// y asi darle un tratamiento especial a esa  excepcion 
//es en orden primero se captura la expecion especifica y luego todas las demas generales 
using System;

namespace tratarexc 
{
    internal class TratarExc
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
                catch(FormatException s)// catch(Exception ex) asi no porque no se puede 
                //capturar de maenra general y luego de maenra especifica 
                {
                    Console.WriteLine("solo numeros ");
                    Minumero = 0;
                }
                catch(Exception ex)//captura un error especifico
                {
                    Console.WriteLine("error general");
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