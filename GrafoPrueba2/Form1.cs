namespace GrafoPrueba2
{
    public partial class Form1 : Form
    {
        Recorrido arbol = new Recorrido();
        Grafo grafo = new Grafo();
        public Form1()
        {
            InitializeComponent();

            tabPage1.Text = "Arbol";
            tabPage2.Text = "Grafo";
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
            string a = comboA.Text;
            string b = comboB.Text;
            int distancia;

            if (!int.TryParse(txtDistancia.Text, out distancia))
            {
                MessageBox.Show("Distancia inválida.");
                return;
            }

            if (grafo.AgregarConexion(a, b, distancia))
            {
                listBoxVisualizar.Items.Add($"{a} - {b} : {distancia}m");
            }
            else
            {
                MessageBox.Show("Ya existe la arista o faltan edificios.");
            }
        }

        private void btnMostrarConexiones_Click(object sender, EventArgs e)
        {
            string nodo = comboA.Text;

            var conexiones = grafo.ObtenerConexionesDe(nodo);

            listBoxVisualizar.Items.Clear();
            foreach (var c in conexiones)
                listBoxVisualizar.Items.Add($"{nodo} → {c}");
        }

        private void btnEsConexo_Click(object sender, EventArgs e)
        {
            string a = comboA.Text;
            string b = comboB.Text;

            if (grafo.ValidarConexion(a, b))
                MessageBox.Show("Los edificios están conectados.");
            else
                MessageBox.Show("NO existe conexión entre esos edificios.");
        }

        private void btnRutaMinima_Click(object sender, EventArgs e)
        {
            string inicio = comboA.Text;

            if (string.IsNullOrWhiteSpace(inicio))
            {
                MessageBox.Show("Seleccione un edificio de inicio.");
                return;
            }

            var (destino, distancia) = grafo.RutaMasCortaDesde(inicio);

            if (destino == null)
            {
                MessageBox.Show("Este edificio no tiene conexiones.");
                return;
            }

            MessageBox.Show($"Ruta más corta:\n{inicio} → {destino} ({distancia} m)", "Ruta mínima");
        }

        private void btnAgregarEdificio_Click(object sender, EventArgs e)
        {
            string nombre = txtEdificio.Text.Trim();

            if (grafo.AgregarNodo(nombre))
            {
                listBoxEdificios.Items.Add(nombre);
                comboA.Items.Add(nombre);
                comboB.Items.Add(nombre);
            }
            else
            {
                MessageBox.Show("Ese edificio ya existe.");
            }

            txtEdificio.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
