using System;

namespace ListaEnlazadaApp
{
    public static class ContadorElementos
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("\n=== Contador de Elementos ===");
            Console.WriteLine("Ingrese los elementos de la lista separados por comas:");
            
            string entrada = Console.ReadLine();
            string[] elementos = entrada.Split(',');

            // Crear lista enlazada
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

            Console.WriteLine($"\nLa lista tiene {contador} elementos.");
            Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
