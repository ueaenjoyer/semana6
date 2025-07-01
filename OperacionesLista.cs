using System;

namespace ListaEnlazadaApp
{
    public static class OperacionesLista
    {
        public static void ContarElementos()
        {
            Console.Clear();
            Console.WriteLine("\n=== Contador de Elementos ===");
            Console.WriteLine("Ingrese los elementos de la lista separados por comas (ej: 1,2,3,4,5):");
            
            string entrada = Console.ReadLine();
            string[] elementos = entrada.Split(',');
            
            Nodo lista = ListaEnlazada.CrearLista(elementos);
            int cantidad = ListaEnlazada.ContarElementos(lista);
            
            Console.WriteLine($"\nLa lista tiene {cantidad} elementos.");
            Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        public static void InvertirLista()
        {
            Console.Clear();
            Console.WriteLine("\n=== Inversor de Lista ===");
            Console.WriteLine("Ingrese los números de la lista separados por comas (ej: 1,2,3,4,5):");
            
            string entrada = Console.ReadLine();
            string[] elementos = entrada.Split(',');
            
            Nodo lista = ListaEnlazada.CrearLista(elementos);
            
            Console.WriteLine("\nLista original:");
            Console.WriteLine(ListaEnlazada.MostrarLista(lista));
            
            Nodo listaInvertida = ListaEnlazada.InvertirLista(lista);
            
            Console.WriteLine("\nLista invertida:");
            Console.WriteLine(ListaEnlazada.MostrarLista(listaInvertida));
            
            Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
