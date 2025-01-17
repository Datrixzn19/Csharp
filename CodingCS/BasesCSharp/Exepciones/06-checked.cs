using System; 
//solo funcioan con int y long 
namespace usoChecked
{
    internal class UsoChecked
    {
        public static void ejercicio1()
        {
 
             //hace que el programa que si hay un error hacer que el programa caiga      
            int numero = int.MaxValue;
            int resultado = checked(numero);
            Console.WriteLine(resultado + 30);
            // unchecked es para cuando todo el proyecto este con checked y unchecked hace 
            //que se ignore esa parte 
            // no cae por que el compilador busca rendimiento
            // pero la respuesta sera erronea 
             
        }
    }
}