using System;

namespace TareaDiccionario
{
    public class Diccionario{
        public static void traductor()
        {


            Console.WriteLine("BIENVENIDOS A MI TRADUCTOR ESPAÑOL - INGLES");
            

            //Inicializar el diccionario 
            Dictionary<string, string> traductor = new Dictionary<string, string>
            {
                //vamos a iniciar con 20 verbos
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
            };









            
            //Frase del usuario
            Console.WriteLine("Ingrese una frase en español, el programa va a traducir las palabras que conozca: ");
            Console.WriteLine();
        
            string? input = Console.ReadLine();
            string frase = input.ToLower();//el imput del usuario en minuscula para trabajar mejor 

            string[] palabras = frase.Split();


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












        }
    }
}