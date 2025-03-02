using System;

namespace TareaDiccionario
{
    public class Diccionario{
        public static void traductor()
        {
            //Inicializar el diccionario 
            Dictionary<string, string> traductor = new Dictionary<string, string>
            {
                //vamos a iniciar con 26 palabras, principalmente verbos y pronombres
                {"caminar","walk"},
                {"correr" , "run"},
                {"jugar" , "play"},
                {"saltar" , "jump"},
                {"poner" , "put"},
                {"cerrar","close"},
                {"reparar" , "fix"},
                {"mover" , "move"},
                {"conducir" , "drive"},
                {"volar" , "fly"},
                {"cantar","sing"},
                {"comer" , "eat"},
                {"mojar" , "wet"},
                {"limpiar" , "clean"},
                {"lavar" , "wash"},
                {"abrir","open"},
                {"romper" , "break"},
                {"coninar" , "cook"},
                {"empujar" , "push"},
                {"ayudar" , "help"},
                {"yo", "i"},
                {"tu", "you"},
                {"el", "he"},
                {"ella", "she"},
                {"nosostros", "we"},
                {"ellos", "they"},
            };


            bool programaActivo = true;//para entrar directamente al do while

            do
            {
                //menu con las opciones
                Console.WriteLine("\n=============================================");
                Console.WriteLine("BIENVENIDOS A MI TRADUCTOR ESPAÑOL - INGLES");
                System.Console.WriteLine("Elije una opción");
                System.Console.WriteLine("1 - Introducir una frase");
                System.Console.WriteLine("2 - Agregar una palabra al diccionario");
                System.Console.WriteLine("3 - Imprimir todo el diccionario");
                System.Console.WriteLine("4 - Salir");

                string? opc = Console.ReadLine();
                int opcion = int.Parse(opc);


//opc 1
                if(opcion == 1)
                {
                   //Frase del usuario
                    Console.WriteLine("Ingrese una frase en español, el programa va a traducir las palabras que conozca: ");
                    Console.WriteLine();
                
                    string? input = Console.ReadLine();
                    string frase = input.ToLower();//el imput del usuario en minuscula para trabajar mejor 

                    //split para separar cada palabra y comprarla de manera independiente en el diccionario
                    string[] palabras = frase.Split();

                    //recorremos cada palabra 
                    //si la encontramos mostramos su traduccion
                    //sino la encontramos le diremos cual fue la que no se pudo encontrar
                    foreach (var item in palabras)
                    {
                        if(traductor.ContainsKey(item))
                        {
                            System.Console.WriteLine($"{item} --> {traductor[item]}");
                            System.Console.WriteLine();
                        }
                        else
                        {
                            System.Console.WriteLine($"La palabra '{item}'  no pudo ser encontrada");
                            System.Console.WriteLine();

                        }
                    }


//opc2
                }
                else if(opcion == 2)//esta opcion agrega key y value 
                {
                    //pedimos la palabra
                    System.Console.WriteLine("Agrege una palabra en español al diccionario");
                    string? palabraInput = Console.ReadLine();
                    //pedimos el significado
                    System.Console.WriteLine($"Agrege el significado en inglés de {palabraInput}");
                    string? significadoInput = Console.ReadLine();

                    traductor[palabraInput] = significadoInput;//de esta manera agregamos el value a la key
                    System.Console.WriteLine("Palabra agregada con éxito");
                }

//opc 3 
                else if(opcion == 3)
                {
                    /*
                    agrege esta opcion porque me parecia buena idea para que el usuario pueda ver las 
                    palabras que estan predefinidas pero sobre todo que vea las que agregó por su cuenta 
                    */
            
                    // imprimir todo el diccionario 
                    foreach (KeyValuePair<string, string>par in traductor)
                    {
                        System.Console.WriteLine($"{par.Key} -- {par.Value}");          
                    }

//opc4
                }
                else if(opcion == 4)
                {
                    break;//break para salir del bucle 
                }

                else
                {
                    System.Console.WriteLine("No has ingresado una opcion correcta");
                }

            }
            while(programaActivo == true);



            System.Console.WriteLine("Programa finalizado");//llegamos aqui si se elige la opcion 4

        }
    }
}