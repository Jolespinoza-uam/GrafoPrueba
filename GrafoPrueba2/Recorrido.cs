using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafoPrueba2
{
    public class Recorrido
    {
        public void PreOrden(TreeNode nodo, List<string> lista)
        {
            if (nodo == null) return;

            lista.Add(nodo.Text);

            foreach (TreeNode hijo in nodo.Nodes)
            {
                PreOrden(hijo, lista);
            }
        }
        public void InOrden(TreeNode nodo, List<string> lista)
        {
            if (nodo == null) return;
            int m = nodo.Nodes.Count / 2; // mitad entera
            for (int i = 0; i < m; i++)
                InOrden(nodo.Nodes[i], lista);

            lista.Add(nodo.Text);

            for (int i = m; i < nodo.Nodes.Count; i++)
                InOrden(nodo.Nodes[i], lista);
        }
        public void PostOrden(TreeNode nodo, List<string> lista)
        {
            if (nodo == null) return;
            foreach (TreeNode hijo in nodo.Nodes)
                PostOrden(hijo, lista);
            lista.Add(nodo.Text);
        }
    }
}
