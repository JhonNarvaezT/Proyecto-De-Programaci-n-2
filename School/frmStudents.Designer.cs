namespace School
{
    partial class frmStudents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtStudentId = new TextBox();
            label3 = new Label();
            txtStudentName = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvEStudiante = new DataGridView();
            panel1 = new Panel();
            txtCarnett = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvEStudiante).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(269, 25);
            label1.Name = "label1";
            label1.Size = new Size(225, 31);
            label1.TabIndex = 0;
            label1.Text = "Lista de estudiantes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 21);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 1;
            label2.Text = "Id de estudiante:";
            // 
            // txtStudentId
            // 
            txtStudentId.Enabled = false;
            txtStudentId.Location = new Point(166, 12);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(125, 27);
            txtStudentId.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1, 76);
            label3.Name = "label3";
            label3.Size = new Size(174, 20);
            label3.TabIndex = 3;
            label3.Text = "Nombre del estudiante:";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(173, 69);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(281, 27);
            txtStudentName.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(3, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(3, 37);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(104, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(104, 37);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvEStudiante
            // 
            dgvEStudiante.AllowUserToAddRows = false;
            dgvEStudiante.AllowUserToDeleteRows = false;
            dgvEStudiante.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEStudiante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEStudiante.Location = new Point(15, 292);
            dgvEStudiante.Name = "dgvEStudiante";
            dgvEStudiante.ReadOnly = true;
            dgvEStudiante.RowHeadersWidth = 51;
            dgvEStudiante.RowTemplate.Height = 29;
            dgvEStudiante.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEStudiante.Size = new Size(753, 255);
            dgvEStudiante.TabIndex = 9;
            dgvEStudiante.CellClick += dgvStudents_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtCarnett);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtStudentId);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtStudentName);
            panel1.Location = new Point(14, 65);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 220);
            panel1.TabIndex = 10;
            // 
            // txtCarnett
            // 
            txtCarnett.Location = new Point(177, 178);
            txtCarnett.Margin = new Padding(3, 4, 3, 4);
            txtCarnett.Name = "txtCarnett";
            txtCarnett.Size = new Size(114, 27);
            txtCarnett.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(115, 185);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 7;
            label5.Text = "Carnet:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(166, 120);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(107, 131);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 5;
            label4.Text = "Grupo:";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAgregar);
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnModificar);
            panel2.Controls.Add(btnLimpiar);
            panel2.Location = new Point(474, 63);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(202, 75);
            panel2.TabIndex = 11;
            // 
            // frmStudents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 556);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvEStudiante);
            Controls.Add(label1);
            Name = "frmStudents";
            Text = "Lista de estudiantes";
            Load += frmStudents_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEStudiante).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtStudentId;
        private Label label3;
        private TextBox txtStudentName;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvEStudiante;
        private Panel panel1;
        private TextBox tCarnet;
        private Label label5;
        private ComboBox comboBox1;
        private Label label4;
        private Panel panel2;
        private TextBox txtCarnet;
        private TextBox txtCarnett;
    }
}