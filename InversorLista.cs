using System;

namespace ListaEnlazadaApp
{
    public static class InversorLista
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("\n=== Inversor de Lista ===");
            Console.WriteLine("Ingrese los números de la lista separados por comas:");
            
            string entrada = Console.ReadLine();
            string[] elementos = entrada.Split(',');

            // Crear lista enlazada original
            Nodo primero = null;
            Nodo actual = null;
            int contador = 0;

            foreach (string elemento in elementos)
            {
                if (int.TryParse(elemento.Trim(), out int valor))
                {
                    Nodo nuevo = new Nodo(valor);
                    if (primero == null)
                    {
                        primero = nuevo;
                        actual = primero;
                    }
                    else
                    {
                        actual.Siguiente = nuevo;
                        actual = actual.Siguiente;
                    }
                    contador++;
                }
            }

            // Mostrar lista original
            Console.WriteLine("\nLista original:");
            MostrarLista(primero);

            // Invertir la lista
            Nodo anterior = null;
            Nodo actualInversion = primero;
            Nodo siguiente = null;

            while (actualInversion != null)
            {
                siguiente = actualInversion.Siguiente;
                actualInversion.Siguiente = anterior;
                anterior = actualInversion;
                actualInversion = siguiente;
            }
            primero = anterior;

            // Mostrar lista invertida
            Console.WriteLine("\nLista invertida:");
            MostrarLista(primero);

            Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        private static void MostrarLista(Nodo primero)
        {
            Nodo actual = primero;
            while (actual != null)
            {
                Console.Write(actual.Valor);
                if (actual.Siguiente != null)
                {
                    Console.Write(" -> ");
                }
                actual = actual.Siguiente;
            }
            Console.WriteLine();
        }
    }
}
