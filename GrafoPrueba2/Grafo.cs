using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafoPrueba2
{
    public class Grafo
    {
        public List<string> Nodos { get; private set; }
        public List<(string, string, int)> Aristas { get; private set; }

        public Grafo()
        {
            Nodos = new List<string>();
            Aristas = new List<(string, string, int)>();
        }

        public bool AgregarNodo(string nombre)
        {
            if (!Nodos.Contains(nombre))
            {
                Nodos.Add(nombre);
                return true;
            }
            return false;
        }

        public bool AgregarConexion(string a, string b, int distancia)
        {
            if (Nodos.Contains(a) && Nodos.Contains(b))
            {
                if (!Aristas.Any(x => (x.Item1 == a && x.Item2 == b) || (x.Item1 == b && x.Item2 == a)))
                {
                    Aristas.Add((a, b, distancia));
                    return true;
                }
            }
            return false;
        }

        public List<(string, int)> ObtenerConexiones(string nodo)
        {
            var lista = new List<(string, int)>();

            foreach (var (a, b, d) in Aristas)
            {
                if (a == nodo) lista.Add((b, d));
                if (b == nodo) lista.Add((a, d));
            }

            return lista;
        }

        public bool ValidarConexion(string a, string b)
        {
            return Aristas.Any(x => (x.Item1 == a && x.Item2 == b) || (x.Item1 == b && x.Item2 == a));
        }

        public List<string> ObtenerConexionesDe(string nodo)
        {
            List<string> conexiones = new List<string>();

            foreach (var (x, y, d) in Aristas)
            {
                if (x == nodo) conexiones.Add(y);
                if (y == nodo) conexiones.Add(x);
            }

            return conexiones;
        }

        public (string destino, int distancia) RutaMasCortaDesde(string inicio)
        {
            var conexiones = ObtenerConexiones(inicio);

            if (conexiones.Count == 0)
                return (null, 0);

            var minima = conexiones.OrderBy(c => c.Item2).First();
            return minima;
        }
    }
}
