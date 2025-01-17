using System;

namespace listasenlazadasPT1
{
    public class Nodo
    {
        public int Valor { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(int valor)
        {
            Valor = valor;
            Siguiente = null;
        }
    }

    // Definición de la clase Lista
    public class Lista
    {
        public Nodo Cabeza { get; private set; }

        public Lista()
        {
            Cabeza = null;
        }

        // Método para agregar un nuevo nodo al final de la lista
        public void Agregar(int valor)
        {
            if (Cabeza == null)
            {
                Cabeza = new Nodo(valor);
            }
            else
            {
                Nodo actual = Cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = new Nodo(valor);
            }
        }

        // Método estático para calcular la longitud de una lista
        public static int CalcularLongitud(Lista lista)
        {
            int contador = 0;
            Nodo actual = lista.Cabeza;

            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }

            return contador;
        }

        // Método principal para ejecutar directamente desde Program.cs
        public static void Ejecutar()
        {
            Lista miLista = new Lista();
            miLista.Agregar(60);
            miLista.Agregar(60);
            miLista.Agregar(50);

            int longitud = CalcularLongitud(miLista);
            Console.WriteLine($"La longitud de la lista es: {longitud}");
        }
    }
}
