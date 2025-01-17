//para cuando el usuario introsduzca una opcion no valida 
using System;
namespace trow
{
    internal class UsoTrow
    {
        public static string nombreMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "enero";

                case 2:
                  return "febreo";

                case 3:
                   return "marzo";

                case 4:
                   return "abril";

                case 5:
                    return "mayo";

                case 6:
                    return "junio";

                case 7:
                    return "julio";

                case 8:
                    return "agosto";

                case 9:
                    return "septiembre";

                case 10:
                    return "octubre";

                case 11:
                    return "novimebre";

                case 12:
                    return "diciembre";
                default:
                    return "diciembre";
                 /*                    trow new ArgumentOutOfRangeException(); 
                
                esto iria en el main 

                Console.WriteLine("Introduce un numero de un mes: ");
                int numeroDeMes = int.Parse(Console.ReadLine());
                try{
                Console.WriteLine(nombreMes(numeroDeMes));
                }catch(Exception e){
                    Console.WriteLine("error general..." + e.Message);
                }
               
                Console.WriteLine("continuacion de programa...);
                
                */
            }
        }
    }
}