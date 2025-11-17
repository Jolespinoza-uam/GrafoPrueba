namespace GrafoPrueba2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnPostOrden = new Button();
            btnInOrden = new Button();
            btnPreOrden = new Button();
            btnContar = new Button();
            btnBuscar = new Button();
            btnAgregarNodo = new Button();
            label1 = new Label();
            txtNodo = new TextBox();
            treeViewArbol = new TreeView();
            btnRutaMinima = new Button();
            groupBox2 = new GroupBox();
            txtDistancia = new TextBox();
            listBoxVisualizar = new ListBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            comboB = new ComboBox();
            comboA = new ComboBox();
            btnEsConexo = new Button();
            btnMostrarConexiones = new Button();
            btnAgregarConexiones = new Button();
            label4 = new Label();
            txtEdificio = new TextBox();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            groupBox3 = new GroupBox();
            listBoxEdificios = new ListBox();
            btnAgregarEdificio = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPostOrden);
            groupBox1.Controls.Add(btnInOrden);
            groupBox1.Controls.Add(btnPreOrden);
            groupBox1.Controls.Add(btnContar);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(btnAgregarNodo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNodo);
            groupBox1.Controls.Add(treeViewArbol);
            groupBox1.Location = new Point(16, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(699, 595);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnPostOrden
            // 
            btnPostOrden.Location = new Point(289, 295);
            btnPostOrden.Name = "btnPostOrden";
            btnPostOrden.Size = new Size(94, 29);
            btnPostOrden.TabIndex = 10;
            btnPostOrden.Text = "PostOrden";
            btnPostOrden.UseVisualStyleBackColor = true;
            btnPostOrden.Click += btnPostOrden_Click;
            // 
            // btnInOrden
            // 
            btnInOrden.Location = new Point(289, 250);
            btnInOrden.Name = "btnInOrden";
            btnInOrden.Size = new Size(94, 29);
            btnInOrden.TabIndex = 9;
            btnInOrden.Text = "InOrden";
            btnInOrden.UseVisualStyleBackColor = true;
            btnInOrden.Click += btnInOrden_Click;
            // 
            // btnPreOrden
            // 
            btnPreOrden.Location = new Point(289, 204);
            btnPreOrden.Name = "btnPreOrden";
            btnPreOrden.Size = new Size(94, 29);
            btnPreOrden.TabIndex = 8;
            btnPreOrden.Text = "PreOrden";
            btnPreOrden.UseVisualStyleBackColor = true;
            btnPreOrden.Click += btnPreOrden_Click;
            // 
            // btnContar
            // 
            btnContar.Location = new Point(401, 113);
            btnContar.Name = "btnContar";
            btnContar.Size = new Size(127, 29);
            btnContar.TabIndex = 6;
            btnContar.Text = "Contar Nodos";
            btnContar.UseVisualStyleBackColor = true;
            btnContar.Click += btnContar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(477, 78);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(127, 29);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar Nodo";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAgregarNodo
            // 
            btnAgregarNodo.Location = new Point(333, 78);
            btnAgregarNodo.Name = "btnAgregarNodo";
            btnAgregarNodo.Size = new Size(138, 29);
            btnAgregarNodo.TabIndex = 3;
            btnAgregarNodo.Text = "Agregar Nodo";
            btnAgregarNodo.UseVisualStyleBackColor = true;
            btnAgregarNodo.Click += btnAgregarNodo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(333, 37);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "Nodo:";
            // 
            // txtNodo
            // 
            txtNodo.Location = new Point(389, 34);
            txtNodo.Name = "txtNodo";
            txtNodo.Size = new Size(191, 27);
            txtNodo.TabIndex = 1;
            // 
            // treeViewArbol
            // 
            treeViewArbol.Location = new Point(0, 36);
            treeViewArbol.Name = "treeViewArbol";
            treeViewArbol.Size = new Size(266, 355);
            treeViewArbol.TabIndex = 0;
            treeViewArbol.AfterSelect += treeViewArbol_AfterSelect;
            // 
            // btnRutaMinima
            // 
            btnRutaMinima.Location = new Point(240, 192);
            btnRutaMinima.Name = "btnRutaMinima";
            btnRutaMinima.Size = new Size(160, 29);
            btnRutaMinima.TabIndex = 7;
            btnRutaMinima.Text = "Calcular ruta mínima";
            btnRutaMinima.UseVisualStyleBackColor = true;
            btnRutaMinima.Click += btnRutaMinima_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDistancia);
            groupBox2.Controls.Add(listBoxVisualizar);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(comboB);
            groupBox2.Controls.Add(comboA);
            groupBox2.Controls.Add(btnRutaMinima);
            groupBox2.Controls.Add(btnEsConexo);
            groupBox2.Controls.Add(btnMostrarConexiones);
            groupBox2.Controls.Add(btnAgregarConexiones);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(381, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(460, 596);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(209, 105);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(125, 27);
            txtDistancia.TabIndex = 17;
            // 
            // listBoxVisualizar
            // 
            listBoxVisualizar.FormattingEnabled = true;
            listBoxVisualizar.Location = new Point(50, 247);
            listBoxVisualizar.Name = "listBoxVisualizar";
            listBoxVisualizar.Size = new Size(376, 244);
            listBoxVisualizar.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(231, 44);
            label6.Name = "label6";
            label6.Size = new Size(21, 20);
            label6.TabIndex = 15;
            label6.Text = "B:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 44);
            label5.Name = "label5";
            label5.Size = new Size(22, 20);
            label5.TabIndex = 14;
            label5.Text = "A:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 17);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 13;
            label3.Text = "Agregar Conexión:";
            // 
            // comboB
            // 
            comboB.FormattingEnabled = true;
            comboB.Location = new Point(258, 41);
            comboB.Name = "comboB";
            comboB.Size = new Size(151, 28);
            comboB.TabIndex = 12;
            // 
            // comboA
            // 
            comboA.FormattingEnabled = true;
            comboA.Location = new Point(50, 43);
            comboA.Name = "comboA";
            comboA.Size = new Size(151, 28);
            comboA.TabIndex = 11;
            // 
            // btnEsConexo
            // 
            btnEsConexo.Location = new Point(45, 192);
            btnEsConexo.Name = "btnEsConexo";
            btnEsConexo.Size = new Size(155, 29);
            btnEsConexo.TabIndex = 8;
            btnEsConexo.Text = "Validar conexión";
            btnEsConexo.UseVisualStyleBackColor = true;
            btnEsConexo.Click += btnEsConexo_Click;
            // 
            // btnMostrarConexiones
            // 
            btnMostrarConexiones.Location = new Point(240, 147);
            btnMostrarConexiones.Name = "btnMostrarConexiones";
            btnMostrarConexiones.Size = new Size(155, 29);
            btnMostrarConexiones.TabIndex = 7;
            btnMostrarConexiones.Text = "Mostrar conexiones";
            btnMostrarConexiones.UseVisualStyleBackColor = true;
            btnMostrarConexiones.Click += btnMostrarConexiones_Click;
            // 
            // btnAgregarConexiones
            // 
            btnAgregarConexiones.Location = new Point(48, 147);
            btnAgregarConexiones.Name = "btnAgregarConexiones";
            btnAgregarConexiones.Size = new Size(152, 29);
            btnAgregarConexiones.TabIndex = 6;
            btnAgregarConexiones.Text = "Agregar conexión";
            btnAgregarConexiones.UseVisualStyleBackColor = true;
            btnAgregarConexiones.Click += btnAgregarConexiones_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 108);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 4;
            label4.Text = "Distancia(metros):";
            // 
            // txtEdificio
            // 
            txtEdificio.Location = new Point(91, 36);
            txtEdificio.Name = "txtEdificio";
            txtEdificio.Size = new Size(169, 27);
            txtEdificio.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 39);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 0;
            label2.Text = "Edificio:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(845, 618);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(837, 585);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(837, 585);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listBoxEdificios);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txtEdificio);
            groupBox3.Controls.Add(btnAgregarEdificio);
            groupBox3.Location = new Point(3, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(381, 582);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            // 
            // listBoxEdificios
            // 
            listBoxEdificios.FormattingEnabled = true;
            listBoxEdificios.Location = new Point(42, 97);
            listBoxEdificios.Name = "listBoxEdificios";
            listBoxEdificios.Size = new Size(289, 444);
            listBoxEdificios.TabIndex = 10;
            // 
            // btnAgregarEdificio
            // 
            btnAgregarEdificio.Location = new Point(266, 35);
            btnAgregarEdificio.Name = "btnAgregarEdificio";
            btnAgregarEdificio.Size = new Size(94, 29);
            btnAgregarEdificio.TabIndex = 9;
            btnAgregarEdificio.Text = "Agregar";
            btnAgregarEdificio.UseVisualStyleBackColor = true;
            btnAgregarEdificio.Click += btnAgregarEdificio_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 632);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Innovatec";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNodo;
        private TreeView treeViewArbol;
        private Button btnRutaMinima;
        private Button btnContar;
        private Button btnBuscar;
        private Button btnAgregarNodo;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtB;
        private TextBox txtEdificio;
        private Label label2;
        private Button btnEsConexo;
        private Button btnMostrarConexiones;
        private Button btnAgregarConexiones;
        private Label label4;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnInOrden;
        private Button btnPreOrden;
        private Button btnPostOrden;
        private Button btnAgregarEdificio;
        private Label label5;
        private Label label3;
        private ComboBox comboB;
        private ComboBox comboA;
        private ListBox listBoxEdificios;
        private ListBox listBoxVisualizar;
        private Label label6;
        private GroupBox groupBox3;
        private TextBox txtDistancia;
    }
}
