namespace Acta_Notas
{
    partial class Asignatura
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
            panel2 = new Panel();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnLimpiar = new Button();
            panel1 = new Panel();
            txtCreditos = new TextBox();
            label5 = new Label();
            cmbSemestre = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            txtAsignaturaId = new TextBox();
            label3 = new Label();
            txtAsignaturaNombre = new TextBox();
            dgvAsignatura = new DataGridView();
            label1 = new Label();
            btnAgregar = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsignatura).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAgregar);
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnModificar);
            panel2.Controls.Add(btnLimpiar);
            panel2.Location = new Point(541, 77);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(202, 75);
            panel2.TabIndex = 15;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(104, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(3, 37);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(104, 37);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtCreditos);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmbSemestre);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtAsignaturaId);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtAsignaturaNombre);
            panel1.Location = new Point(80, 80);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 220);
            panel1.TabIndex = 14;
            // 
            // txtCreditos
            // 
            txtCreditos.Location = new Point(166, 175);
            txtCreditos.Margin = new Padding(3, 4, 3, 4);
            txtCreditos.Name = "txtCreditos";
            txtCreditos.Size = new Size(114, 27);
            txtCreditos.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(95, 185);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 7;
            label5.Text = "Creditos:";
            // 
            // cmbSemestre
            // 
            cmbSemestre.FormattingEnabled = true;
            cmbSemestre.Items.AddRange(new object[] { "Primer Semestre", "Segundo Semestre" });
            cmbSemestre.Location = new Point(166, 120);
            cmbSemestre.Margin = new Padding(3, 4, 3, 4);
            cmbSemestre.Name = "cmbSemestre";
            cmbSemestre.Size = new Size(138, 28);
            cmbSemestre.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(83, 131);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 5;
            label4.Text = "Semestre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 21);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 1;
            label2.Text = "Id de asignatura:";
            // 
            // txtAsignaturaId
            // 
            txtAsignaturaId.Enabled = false;
            txtAsignaturaId.Location = new Point(166, 12);
            txtAsignaturaId.Name = "txtAsignaturaId";
            txtAsignaturaId.Size = new Size(125, 27);
            txtAsignaturaId.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1, 76);
            label3.Name = "label3";
            label3.Size = new Size(174, 20);
            label3.TabIndex = 3;
            label3.Text = "Nombre de  asignatura:";
            // 
            // txtAsignaturaNombre
            // 
            txtAsignaturaNombre.Location = new Point(166, 65);
            txtAsignaturaNombre.Name = "txtAsignaturaNombre";
            txtAsignaturaNombre.Size = new Size(281, 27);
            txtAsignaturaNombre.TabIndex = 4;
            // 
            // dgvAsignatura
            // 
            dgvAsignatura.AllowUserToAddRows = false;
            dgvAsignatura.AllowUserToDeleteRows = false;
            dgvAsignatura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAsignatura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsignatura.Location = new Point(81, 307);
            dgvAsignatura.Name = "dgvAsignatura";
            dgvAsignatura.ReadOnly = true;
            dgvAsignatura.RowHeadersWidth = 51;
            dgvAsignatura.RowTemplate.Height = 29;
            dgvAsignatura.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAsignatura.Size = new Size(753, 255);
            dgvAsignatura.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(335, 40);
            label1.Name = "label1";
            label1.Size = new Size(225, 31);
            label1.TabIndex = 12;
            label1.Text = "Lista de estudiantes";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(4, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button1_Click;
            // 
            // Asignatura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvAsignatura);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Asignatura";
            Text = "Asignatura";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsignatura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnLimpiar;
        private Panel panel1;
        private TextBox txtCreditos;
        private Label label5;
        private ComboBox cmbSemestre;
        private Label label4;
        private Label label2;
        private TextBox txtAsignaturaId;
        private Label label3;
        private TextBox txtAsignaturaNombre;
        private DataGridView dgvAsignatura;
        private Label label1;
        private Button button1;
    }
}