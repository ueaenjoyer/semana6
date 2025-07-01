using System;
using System.Collections.Generic;

namespace ListaEnlazadaApp
{
    public static class ContadorLista
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("\n=== Contar Elementos de una Lista ===");
            Console.WriteLine("Ingrese elementos de la lista separados por comas (ej: manzana,pera,banana):");
            
            string entrada = Console.ReadLine();
            string[] elementos = entrada.Split(',');

            // Limpiar los espacios en blanco de cada elemento
            for (int i = 0; i < elementos.Length; i++)
            {
                elementos[i] = elementos[i].Trim();
            }

            Console.WriteLine("\nResultado:");
            Console.WriteLine($"La lista tiene {elementos.Length} elementos.");
            Console.WriteLine("Elementos en la lista:");
            for (int i = 0; i < elementos.Length; i++)
            {
                Console.WriteLine($"[{i}] {elementos[i]}");
            }
            
            Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
