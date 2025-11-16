namespace GrafoPrueba2
{
    public partial class Form1 : Form
    {
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

        private void Orden(TreeNode node, List<string> lista)
        {
            lista.Add(node.Text);
            foreach (TreeNode hijo in node.Nodes)
                Orden(hijo, lista);
        }
        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            if (treeViewArbol.SelectedNode == null)
            {
                MessageBox.Show("Selecciona un nodo primero.");
                return;
            }

            List<string> recorrido = new List<string>();
            Orden(treeViewArbol.SelectedNode, recorrido);

            MessageBox.Show(
                $"Recorrido desde \"{treeViewArbol.SelectedNode.Text}\":\n" +
                string.Join(" -> ", recorrido)
            );
        }
    }
}
