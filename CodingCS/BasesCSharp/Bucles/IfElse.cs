using System;
using System.Dynamic;
namespace IfElse
{
    internal class BucleIf
    {

        public static void ifelse()
        {
            //if else

            Console.WriteLine("Intruduce tu edad");
            string edad = (Console.ReadLine());
            int conversionDeEdad = int.Parse(edad);

            if(conversionDeEdad > 17)
            {
                Console.WriteLine("Usted es mayor de edad");
            }
            else
            {
                Console.WriteLine("Usted es menor de edad");
            }

        }

    }
}