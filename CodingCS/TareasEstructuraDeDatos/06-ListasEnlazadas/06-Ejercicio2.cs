using System;


namespace listasenlazadasPT2
{      

    public class Elemento
    {
        public int Dato { get; set; }
        public Elemento Proximo { get; set; }

        public Elemento(int dato)
        {
            Dato = dato;
            Proximo = null;
        }
    }

    // Lista Enlazada
    public class ListaEnlazada
    {
        public Elemento Inicio { get; private set; }

        public ListaEnlazada()
        {
            Inicio = null;
        }

        // aqui se agragaa un nuevo elemento al final de la lista
        public void Agregar(int dato)
        {
            if (Inicio == null)
            {
                Inicio = new Elemento(dato);
            }
            else
            {
                Elemento actual = Inicio;
                while (actual.Proximo != null)//diferente de nulo
                {
                    actual = actual.Proximo;
                }
                actual.Proximo = new Elemento(dato);
            }
        }

        // Método estático para calcular la longitud de una lista enlazada
        public static int ContarElementos(ListaEnlazada lista)
        {
            int contador = 0;
            Elemento actual = lista.Inicio;

            while (actual != null)
            {
                contador++;
                actual = actual.Proximo;
            }

            return contador;
        }

        // Método para invertir la lista enlazada
        public void InvertirLista()
        {
            Elemento anterior = null;
            Elemento actual = Inicio;
            Elemento siguiente = null;

            while (actual != null)
            {
                siguiente = actual.Proximo;
                actual.Proximo = anterior;
                anterior = actual;
                actual = siguiente;
            }

            Inicio = anterior;
        }

        // Método principal para ejecutar directamente desde Program.cs
        public static void Ejecutar()
        {
            ListaEnlazada miLista = new ListaEnlazada();
            //agregamos varion numeros para hacer la prueba            
            miLista.Agregar(1);
            miLista.Agregar(2);
            miLista.Agregar(3);
            miLista.Agregar(4);
            miLista.Agregar(5);
            miLista.Agregar(6);

            Console.WriteLine("Lista original:");
            ImprimirLista(miLista);

            miLista.InvertirLista();

            Console.WriteLine("Lista ya invertida:");
            ImprimirLista(miLista);
        }

        // Método para imprimir la lista enlazada
        public static void ImprimirLista(ListaEnlazada lista)
        {
            Elemento actual = lista.Inicio;
            while (actual != null)
            {
                Console.Write(actual.Dato + " ~ ");
                actual = actual.Proximo;
            }
            Console.WriteLine("fin...");
        }
    }
}
