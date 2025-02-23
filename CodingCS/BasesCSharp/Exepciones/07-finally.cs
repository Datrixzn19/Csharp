// el finally siempre se va a ejecutar
// se lo puede usar para cerrar conexiones y liberrar memoria 

using System;
namespace expresionfinally
{
    internal class expresionFinally
    {
        public static void ejercicio1()
        {
            System.IO.StreamReader archivo = null;
            try
            {
                string linea;
                int contador = 0;
                string ruta = @"/home/datrixzn19/Desktop/pruebatxt";
                archivo = new System.IO.StreamReader(ruta);
                while((linea = archivo.ReadLine()) != null);
                {
                    Console.WriteLine(linea);
                    contador++;

                }
            }
            catch(Exception e)
            {
                Console.WriteLine("algo salio mal");
            }
            finally
            {
                if (archivo!= null) archivo.Close();
                Console.WriteLine("coneccion cerrada");
            }
        }
    }
}