using System;

namespace ListaEnlazadaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("\n=== Menú Principal ===");
                Console.WriteLine("1. Contar elementos de la lista");
                Console.WriteLine("2. Invertir lista");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        OperacionesLista.ContarElementos();
                        break;
                    case "2":
                        OperacionesLista.InvertirLista();
                        break;
                    case "3":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
