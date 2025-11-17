namespace GrafoPrueba2
{
    public partial class Form1 : Form
    {
        Dictionary<string, List<(string destino, int peso)>> grafo =
        new Dictionary<string, List<(string destino, int peso)>>();

        Recorrido arbol = new Recorrido();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregarNodo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNodo.Text))
            {
                MessageBox.Show("Ingrese un nombre de nodo.");
                return;
            }

            if (treeViewArbol.SelectedNode == null)
            {
                treeViewArbol.Nodes.Add(txtNodo.Text);
            }
            else
            {
                // Agregar como hijo
                treeViewArbol.SelectedNode.Nodes.Add(txtNodo.Text);
                treeViewArbol.SelectedNode.Expand();
            }

            txtNodo.Clear();
        }

        private void treeViewArbol_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private TreeNode Buscar(TreeNode node, string texto)
        {
            if (node.Text == texto)
                return node;

            foreach (TreeNode hijo in node.Nodes)
            {
                TreeNode encontrado = Buscar(hijo, texto);
                if (encontrado != null)
                    return encontrado;
            }

            return null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtNodo.Text;

            foreach (TreeNode root in treeViewArbol.Nodes)
            {
                TreeNode nodo = Buscar(root, texto);
                if (nodo != null)
                {
                    treeViewArbol.SelectedNode = nodo;
                    nodo.EnsureVisible();
                    MessageBox.Show("Nodo encontrado.");
                    return;
                }
            }

            MessageBox.Show("Nodo NO encontrado.");
        }

        private int Contar(TreeNode node)
        {
            int total = 1;

            foreach (TreeNode hijo in node.Nodes)
                total += Contar(hijo);

            return total;
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            int total = 0;

            foreach (TreeNode root in treeViewArbol.Nodes)
                total += Contar(root);

            MessageBox.Show("Total de nodos: " + total);
        }

        // Recorridos
        private TreeNode BuscarNodo(TreeNodeCollection nodos, string texto)
        {
            foreach (TreeNode n in nodos)
            {
                if (n.Text == texto)
                    return n;

                TreeNode encontrado = BuscarNodo(n.Nodes, texto);
                if (encontrado != null)
                    return encontrado;
            }

            return null;
        }

        private async Task SubrayarRecorrido(List<string> recorrido)
        {
            foreach (string texto in recorrido)
            {
                TreeNode nodo = BuscarNodo(treeViewArbol.Nodes, texto);
                if (nodo != null)
                {
                    treeViewArbol.SelectedNode = nodo;
                    nodo.EnsureVisible();
                }

                await Task.Delay(700);
            }
        }

        private async void btnPreOrden_Click(object sender, EventArgs e)
        {
            if (treeViewArbol.Nodes.Count == 0) return;

            List<string> recorrido = new List<string>();

            foreach (TreeNode root in treeViewArbol.Nodes)
                arbol.PreOrden(root, recorrido);

            await SubrayarRecorrido(recorrido);

        }

        private async void btnInOrden_Click(object sender, EventArgs e)
        {
            if (treeViewArbol.Nodes.Count == 0) return;

            List<string> recorrido = new List<string>();

            foreach (TreeNode root in treeViewArbol.Nodes)
                arbol.PreOrden(root, recorrido);

            await SubrayarRecorrido(recorrido);
        }

        private async void btnPostOrden_Click(object sender, EventArgs e)
        {
            if (treeViewArbol.Nodes.Count == 0) return;

            List<string> recorrido = new List<string>();

            foreach (TreeNode root in treeViewArbol.Nodes)
                arbol.PreOrden(root, recorrido);

            await SubrayarRecorrido(recorrido);
        }

        // Grafo

        private void btnAgregarConexiones_Click(object sender, EventArgs e)
        {
            string A = txtA.Text;
            string B = txtB.Text;
            int d = (int)numDistancia.Value;

            if (!grafo.ContainsKey(A)) grafo[A] = new List<(string, int)>();
            if (!grafo.ContainsKey(B)) grafo[B] = new List<(string, int)>();

            grafo[A].Add((B, d));
            grafo[B].Add((A, d));

            MessageBox.Show("Conexión agregada.");
        }

        private void btnMostrarConexiones_Click(object sender, EventArgs e)
        {
            string res = "";

            foreach (var nodo in grafo)
            {
                res += $"{nodo.Key}: ";
                res += string.Join(", ", nodo.Value.Select(x => $"{x.destino}({x.peso})"));
                res += "\n";
            }

            MessageBox.Show(res, "Conexiones");
        }

        private void btnEsConexo_Click(object sender, EventArgs e)
        {
            if (grafo.Count == 0)
            {
                MessageBox.Show("El grafo está vacío.");
                return;
            }

            string start = grafo.Keys.First();
            HashSet<string> visitados = new HashSet<string>();

            void DFS(string v)
            {
                visitados.Add(v);
                foreach (var (dest, _) in grafo[v])
                    if (!visitados.Contains(dest))
                        DFS(dest);
            }

            DFS(start);

            if (visitados.Count == grafo.Count)
                MessageBox.Show("El grafo es conexo.");
            else
                MessageBox.Show("El grafo NO es conexo.");
        }

        private void btnRutaMinima_Click(object sender, EventArgs e)
        {
            string inicio = txtA.Text;
            string fin = txtB.Text;

            var dist = new Dictionary<string, int>();
            var prev = new Dictionary<string, string>();
            var pq = new SortedSet<(int d, string nodo)>();

            foreach (var v in grafo.Keys)
            {
                dist[v] = int.MaxValue;
                prev[v] = null;
            }

            dist[inicio] = 0;
            pq.Add((0, inicio));

            while (pq.Count > 0)
            {
                var (d, u) = pq.First();
                pq.Remove(pq.First());

                if (u == fin) break;

                foreach (var (v, peso) in grafo[u])
                {
                    int nd = d + peso;
                    if (nd < dist[v])
                    {
                        pq.Remove((dist[v], v));
                        dist[v] = nd;
                        prev[v] = u;
                        pq.Add((nd, v));
                    }
                }
            }

            if (dist[fin] == int.MaxValue)
            {
                MessageBox.Show("No existe ruta.");
                return;
            }

            List<string> camino = new List<string>();
            string temp = fin;
            while (temp != null)
            {
                camino.Add(temp);
                temp = prev[temp];
            }
            camino.Reverse();

            MessageBox.Show("Ruta mínima:\n" + string.Join(" -> ", camino) +
                            "\nDistancia total: " + dist[fin]);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
