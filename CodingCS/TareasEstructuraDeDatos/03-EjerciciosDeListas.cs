using System;
using System.Collections.Generic;
using System.Linq;
namespace EjerciciosDeListas
{
    public class EjerciciosSimples
    {
        
        public static void Ejercicio1()
        {
            /*
            Programa que almacene las asignaturas de un curso 
            y las muestre en pantalla
            */
            // Crear una nueva lista de números enteros
            List<string> asignaturas = new List<string>() 
            {
            "Matematicas", 
            "Literatura", 
            "Ciencias Sociales",
            "Fisica",
            "Quimica",
            "Filosofia"
            };

            foreach (string asignatura in asignaturas)
            {
                Console.WriteLine(asignatura);
            }      
        }




        public static void Ejercicio2()
        /*
        Hacer una lista con los numeros del uno al diez 
        imprimir la lista invertida
        */
        {
            // Lista con numeros del 1 al 10
            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Invertir la lista con el metodo Reverse
            numeros.Reverse();
            Console.WriteLine("Números en orden inverso: " + string.Join(", ", numeros));
        }
        



        public static bool Ejercicio3()  
        //pedir una palabra al usuario y verificar si es palindromo 
        {
                Console.Write("Introduce una palabra: ");
                string palabra = Console.ReadLine();
    
                // verificar si es palíndromo
                palabra = new string(palabra.ToLower().Where(c => char.IsLetter(c)).ToArray());
                bool esPalindromo = palabra.SequenceEqual(palabra.Reverse());
    
                Console.WriteLine($"'{palabra}' {(esPalindromo ? "es" : "no es")} un palíndromo");
    
                return esPalindromo;
        }




        public static void Ejercicio4()
        /*
        pedir al usuario una palabra
        imprimir cuantas veces se repite cada vocal
        */
        {

            Console.Write("Introduce una palabra: ");
            string palabra = Console.ReadLine().ToLower();

            // Contadors para las vocales 
            int contarA = 0;
            int contarE = 0;
            int contarI = 0; 
            int contarO = 0;
            int contarU = 0;

            // contar vocales 
            foreach(char letra in palabra)
            {
                switch(letra)
                {
                    case 'a':
                        contarA++;
                        break;
                    case 'e':
                        contarE++;
                        break;
                    case 'i':
                        contarI++;
                        break;
                    case 'o':
                        contarO++;
                        break;
                    case 'u':
                        contarU++;
                        break;
                }
            }

            Console.WriteLine($"La vocal 'a' aparece {contarA} veces");
            Console.WriteLine($"La vocal 'e' aparece {contarE} veces");
            Console.WriteLine($"La vocal 'i' aparece {contarI} veces");
            Console.WriteLine($"La vocal 'o' aparece {contarO} veces");
            Console.WriteLine($"La vocal 'u' aparece {contarU} veces");
        }


        public static void Ejercicio5()
            {
                Console.WriteLine("Ingrese una muestra de números separados por comas:");
                string input = Console.ReadLine();
                
                // Separar los números y validar la entrada
                string[] partes = input.Split(',');
                List<double> numeros = new List<double>();
                
                foreach (string parte in partes)
                {
                    if (double.TryParse(parte.Trim(), out double numero))
                    {
                        numeros.Add(numero);
                    }
                    else
                    {
                        Console.WriteLine($"Error: '{parte.Trim()}' no es un número válido.");
                        return;
                    }
                }

                if (numeros.Count == 0)
                {
                    Console.WriteLine("La lista de números está vacía.");
                    return;
                }

                // Calculamos la media 
                double media = numeros.Average();

                // Calculamos la desviacion tipica
                double sumaCuadrados = numeros.Sum(num => Math.Pow(num - media, 2));
                double desviacionTipica = Math.Sqrt(sumaCuadrados / numeros.Count);

                Console.WriteLine($"Media: {media:F2}");
                Console.WriteLine($"Desviación típica: {desviacionTipica:F2}");
            }




    }
}
