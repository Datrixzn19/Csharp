 // EL progrma va contar el numero de vocales que tenga una palabra ingresada por el usuario 
 //pedirle el input al usuario
 // un foreach para separarar las letras y dentro un if preguntando si son vocales 
 
using System;
namespace contarVocales
{
    internal class ContarVocales
    {
        public static void contar()
        {
            int contar = 0;

            System.Console.WriteLine("EL programa calculara el total de letras que tenga su palabra");
            System.Console.WriteLine("Porfavor introduce una palabra: ");

            //string inputusuario = Console.ReadLine();
            //string palabra = inputusuario.ToLower();
            
            string[] valid = {"a", "e", "i", "o", "u"};    
            foreach (var item in valid)
            {
                System.Console.WriteLine(item);
            }

//la idea es ver si el iten se encuantra en el arrays valid 
//conttrol k c
            // foreach (char item in palabra)
            // {
            //     if( )
            //     {
            //         contar += 1;
            //     }
            // }
















        }
    }

}