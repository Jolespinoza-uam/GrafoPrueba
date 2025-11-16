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
            btnRutaMinima = new Button();
            btnContar = new Button();
            btnRecorrer = new Button();
            btnBuscar = new Button();
            btnAgregarNodo = new Button();
            label1 = new Label();
            txtNodo = new TextBox();
            treeViewArbol = new TreeView();
            groupBox2 = new GroupBox();
            btnEsConexo = new Button();
            btnMostrarConexiones = new Button();
            btnAgregarConexiones = new Button();
            numDistancia = new NumericUpDown();
            label4 = new Label();
            txtB = new TextBox();
            txtA = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDistancia).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRutaMinima);
            groupBox1.Controls.Add(btnContar);
            groupBox1.Controls.Add(btnRecorrer);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(btnAgregarNodo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNodo);
            groupBox1.Controls.Add(treeViewArbol);
            groupBox1.Location = new Point(8, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(446, 595);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnRutaMinima
            // 
            btnRutaMinima.Location = new Point(134, 531);
            btnRutaMinima.Name = "btnRutaMinima";
            btnRutaMinima.Size = new Size(160, 29);
            btnRutaMinima.TabIndex = 7;
            btnRutaMinima.Text = "Calcular ruta mínima";
            btnRutaMinima.UseVisualStyleBackColor = true;
            // 
            // btnContar
            // 
            btnContar.Location = new Point(222, 496);
            btnContar.Name = "btnContar";
            btnContar.Size = new Size(127, 29);
            btnContar.TabIndex = 6;
            btnContar.Text = "Contar Nodos";
            btnContar.UseVisualStyleBackColor = true;
            btnContar.Click += btnContar_Click;
            // 
            // btnRecorrer
            // 
            btnRecorrer.Location = new Point(67, 494);
            btnRecorrer.Name = "btnRecorrer";
            btnRecorrer.Size = new Size(135, 29);
            btnRecorrer.TabIndex = 5;
            btnRecorrer.Text = "Recorridos";
            btnRecorrer.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(222, 461);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(127, 29);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar Nodo";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAgregarNodo
            // 
            btnAgregarNodo.Location = new Point(64, 459);
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
            label1.Location = new Point(19, 408);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "Nodo:";
            // 
            // txtNodo
            // 
            txtNodo.Location = new Point(75, 405);
            txtNodo.Name = "txtNodo";
            txtNodo.Size = new Size(345, 27);
            txtNodo.TabIndex = 1;
            // 
            // treeViewArbol
            // 
            treeViewArbol.Location = new Point(19, 27);
            treeViewArbol.Name = "treeViewArbol";
            treeViewArbol.Size = new Size(414, 355);
            treeViewArbol.TabIndex = 0;
            treeViewArbol.AfterSelect += treeViewArbol_AfterSelect;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEsConexo);
            groupBox2.Controls.Add(btnMostrarConexiones);
            groupBox2.Controls.Add(btnAgregarConexiones);
            groupBox2.Controls.Add(numDistancia);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtB);
            groupBox2.Controls.Add(txtA);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(468, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(370, 596);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // btnEsConexo
            // 
            btnEsConexo.Location = new Point(54, 237);
            btnEsConexo.Name = "btnEsConexo";
            btnEsConexo.Size = new Size(155, 29);
            btnEsConexo.TabIndex = 8;
            btnEsConexo.Text = "Validar conexión";
            btnEsConexo.UseVisualStyleBackColor = true;
            // 
            // btnMostrarConexiones
            // 
            btnMostrarConexiones.Location = new Point(54, 202);
            btnMostrarConexiones.Name = "btnMostrarConexiones";
            btnMostrarConexiones.Size = new Size(155, 29);
            btnMostrarConexiones.TabIndex = 7;
            btnMostrarConexiones.Text = "Mostrar conexiones";
            btnMostrarConexiones.UseVisualStyleBackColor = true;
            // 
            // btnAgregarConexiones
            // 
            btnAgregarConexiones.Location = new Point(54, 167);
            btnAgregarConexiones.Name = "btnAgregarConexiones";
            btnAgregarConexiones.Size = new Size(152, 29);
            btnAgregarConexiones.TabIndex = 6;
            btnAgregarConexiones.Text = "Agregar conexión";
            btnAgregarConexiones.UseVisualStyleBackColor = true;
            // 
            // numDistancia
            // 
            numDistancia.Location = new Point(108, 121);
            numDistancia.Name = "numDistancia";
            numDistancia.Size = new Size(150, 27);
            numDistancia.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 128);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 4;
            label4.Text = "Distancia:";
            // 
            // txtB
            // 
            txtB.Location = new Point(108, 79);
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 27);
            txtB.TabIndex = 3;
            // 
            // txtA
            // 
            txtA.Location = new Point(108, 34);
            txtA.Name = "txtA";
            txtA.Size = new Size(125, 27);
            txtA.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 79);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 1;
            label3.Text = "Edificio B:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 37);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 0;
            label2.Text = "Edificio A:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 632);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDistancia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNodo;
        private TreeView treeViewArbol;
        private Button btnRutaMinima;
        private Button btnContar;
        private Button btnRecorrer;
        private Button btnBuscar;
        private Button btnAgregarNodo;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtB;
        private TextBox txtA;
        private Label label3;
        private Label label2;
        private Button btnEsConexo;
        private Button btnMostrarConexiones;
        private Button btnAgregarConexiones;
        private NumericUpDown numDistancia;
        private Label label4;
    }
}
