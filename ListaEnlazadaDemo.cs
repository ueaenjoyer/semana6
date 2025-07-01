using System;
using System.Collections.Generic;

namespace ListaEnlazadaApp
{
    // Clase para demostrar la inversión de una lista
    public static class ListaEnlazadaDemo
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("\n=== Invertir una Lista ===");
            Console.WriteLine("Ingrese los números de la lista separados por comas (ej: 1,2,3,4,5):");
            
            string entrada = Console.ReadLine();
            string[] elementos = entrada.Split(',');
            
            List<int> numeros = new List<int>();
            
            // Procesar la entrada y convertir a números
            foreach (string elemento in elementos)
            {
                if (int.TryParse(elemento.Trim(), out int numero))
                {
                    numeros.Add(numero);
                }
            }
            
            // Mostrar la lista original
            Console.WriteLine("\nLista original:");
            MostrarLista(numeros);
            
            // Invertir la lista
            Console.WriteLine("\nLista invertida:");
            numeros.Reverse();
            MostrarLista(numeros);
            
            Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
        
        private static void MostrarLista(List<int> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write(lista[i]);
                if (i < lista.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine($"\nTotal de elementos: {lista.Count}");
        }
    }
}
