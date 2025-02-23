/*
Lista de cuidadanos vacunados solo con Pfizer
Lista de cuidadanos vacunados solo con Astrazenceca 
Lista de cuidadanos vacunados con las dos 
Lista de cuidadanos no vacunados 

    Resolver:
Crear conjunto de 500 personas 
Conjunto de 75 personas vacunados con pfizer
conjunto de 75 personas vacunadas con astrazeneca
*/
using System;
using System.Collections.Generic;

namespace semana10conjuntos
{
    public class Conjuntos
    {
        public static void ejercicio()
        {
            Random aleatorio = new Random();//generar numero aleatorios para identificar ciudadanos 



//500 personas 
            HashSet<string> ciudadanos = new HashSet<string>();//conjunto con 500 personas agg. 

            while(ciudadanos.Count() < 500)
            {
                ciudadanos.Add("Ciudadano " + aleatorio.Next(1, 1000));// del 1 al 700 para variar un poco
            }


            

//vacunados con pfizer
             HashSet<string> pfizer = new HashSet<string>();//conjunto con 75 personas vacunadas con pfizer
              while(pfizer.Count() < 75)
            {
                pfizer.Add("Ciudadano " + aleatorio.Next(1, 1000));// del 1 al 700 para variar un poco
            }



//vacunados con astrazeneca
             HashSet<string> astrazeneca = new HashSet<string>();//75 personas vacunadas con astrazeneca
              while(astrazeneca.Count() < 75)
            {
                astrazeneca.Add("Ciudadano " + aleatorio.Next(1, 1000));// del 1 al 700 para variar un poco
            } 




                                        // Imprimir las listas

// Vacunados solo con Pfizer
            Console.WriteLine("Lista de vacunados solo con Pfizer");
        
            var soloPfizer = new HashSet<string>(pfizer); // Nuevos conjuntos para no hacer cambios en los originales
            soloPfizer.ExceptWith(astrazeneca); // Diferencia(pfizer - astrazeneca)
            foreach (var persona in soloPfizer)
            {
                Console.WriteLine(persona);
            }

// Vacunados solo con AstraZeneca
            Console.WriteLine();
            Console.WriteLine("Lista de vacunados solo con AstraZeneca");
            var soloAstrazeneca = new HashSet<string>(astrazeneca);
            soloAstrazeneca.ExceptWith(pfizer); // Diferencia(astrazeneca - pfizer)
            foreach (var persona in soloAstrazeneca)
            {
                Console.WriteLine(persona);
            }



// Personas sin ninguna vacuna
            Console.WriteLine();
            Console.WriteLine("Lista de no vacunados");
            var noVacunados = new HashSet<string>(ciudadanos);

            noVacunados.ExceptWith(pfizer); // Eliminar vacunados con Pfizer
            noVacunados.ExceptWith(astrazeneca); // Eliminar vacunados con AstraZeneca
            // como eliminamos los vacunados con pfizer y astrazeneca solo nos quedan los no vacunados 
             foreach (var persona in noVacunados)
             {
                 Console.WriteLine(persona);
             }

// Personas con ambas vacunas
            Console.WriteLine();
            Console.WriteLine("Lista de personas vacunadas con Pfizer y AstraZeneca (Podria estar vacio)");
            var ambasVacunas = new HashSet<string>(pfizer);
            ambasVacunas.IntersectWith(astrazeneca);// Intersección
         
            foreach (var persona in ambasVacunas)
            {
                Console.WriteLine(persona);
            }
        }
    }
}