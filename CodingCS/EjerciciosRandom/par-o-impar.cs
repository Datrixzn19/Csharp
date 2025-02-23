//Crea un programa para determinar si un numero es par o impar
//el usuario introducira el numero


//pedirle un int al usuario con readline
//convertirlo a numero
//sacarle el cociente con %
//un if para ver si es cero dar el mensaje de que es par


using System;
using System.Runtime.Intrinsics.Arm;

namespace paroimpar
{
    public class Par
    {
        public static void comprobar()
        {

            
            Console.WriteLine("El programa indentificara si un numero es par o impar");
            

            bool continuar = true;

            while(continuar)
            {
            System.Console.WriteLine("Ingresa tu numero: ");
                try
                {
                    int intUser = int.Parse(Console.ReadLine()); 

                    if(intUser%2 == 0)
                {
                    Console.WriteLine($"El numero {intUser} es par");
                }
                else
                {
                    Console.WriteLine($"El numero {intUser} es impar");
                }

                    
                }
                catch(Exception ex)
                {
                    System.Console.WriteLine("Dato no valido");

                    int intUser;
                }
                


                

                System.Console.WriteLine();
                System.Console.WriteLine("Deseas intentarlo de nuevo? y/n");
                string inputUser = Console.ReadLine();
                string seguir = inputUser.ToLower();


            
                if(seguir == "y") 
                {
                    System.Console.WriteLine();            
                    continuar = true;
                }
                else if(seguir == "n") 
                {
                    System.Console.WriteLine("Saliendo....");
                    continuar = false;
                }

                else
                {
                    System.Console.WriteLine("OPCION ESCOGIDA NO VALIDA");
                    System.Console.WriteLine("Saliendo....");
                    continuar = false;
                }
                

                
                









            }







        }
    }

}