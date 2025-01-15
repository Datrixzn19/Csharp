using System;

namespace forEach
{
    internal class Bucleforeach
    {
        public static void ejemplo1(){
            int[] numeros = {3, 4 ,6 ,6 ,4 };

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        
        }
    }
}