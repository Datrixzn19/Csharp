// busca captar todas las expeciones cuando sean difernetes de algun error especifico
// y asi luego tratar ese error especifico despues
/*por que normal mente si lo hacemos primero captar erroes generaeles y luego un 
especifico pues no va a funcionar*/
using System;

namespace excConFiltro 
{
    internal class ExcConFiltro
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
                catch(Exception e) when (e.GetType()!= typeof(FormatException))
                /*
                get type es un objetop de la clase e 
                va a capturar expeciones generales que sean diferente de algun erro especif.
                */
                {
                    Console.WriteLine("error general");
                    Minumero = 0;
                }
                catch(FormatException)
                {
                     Console.WriteLine("error con filtro ");
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