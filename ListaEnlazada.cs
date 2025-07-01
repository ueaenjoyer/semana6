namespace ListaEnlazadaApp
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

    public static class ListaEnlazada
    {
        public static Nodo CrearLista(string[] elementos)
        {
            Nodo primero = null;
            Nodo actual = null;

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
                }
            }
            return primero;
        }

        public static int ContarElementos(Nodo primero)
        {
            int contador = 0;
            Nodo actual = primero;
            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }
            return contador;
        }

        public static Nodo InvertirLista(Nodo primero)
        {
            Nodo anterior = null;
            Nodo actual = primero;
            Nodo siguiente = null;

            while (actual != null)
            {
                siguiente = actual.Siguiente;
                actual.Siguiente = anterior;
                anterior = actual;
                actual = siguiente;
            }
            return anterior;
        }

        public static string MostrarLista(Nodo primero)
        {
            string resultado = "";
            Nodo actual = primero;
            while (actual != null)
            {
                resultado += actual.Valor;
                if (actual.Siguiente != null)
                {
                    resultado += " -> ";
                }
                actual = actual.Siguiente;
            }
            return resultado + (string.IsNullOrEmpty(resultado) ? "" : " -> null");
        }
    }
}
