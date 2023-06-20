namespace Acta_Notas
{
    partial class Calificacion
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
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnLimpiar = new Button();
            panel1 = new Panel();
            txtnotaIIP = new TextBox();
            label7 = new Label();
            txtnotaIP = new TextBox();
            label6 = new Label();
            cmbAsignatura = new ComboBox();
            label3 = new Label();
            txtNotaS = new TextBox();
            label5 = new Label();
            cmbEstudiante = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            txtStudentId = new TextBox();
            dgvCalificacion = new DataGridView();
            label1 = new Label();
            txtNF = new TextBox();
            label8 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCalificacion).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAgregar);
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnModificar);
            panel2.Controls.Add(btnLimpiar);
            panel2.Location = new Point(415, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(177, 56);
            panel2.TabIndex = 15;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(3, 2);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 22);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(91, 2);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 22);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(3, 28);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(82, 22);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(91, 28);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(82, 22);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtNF);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtnotaIIP);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtnotaIP);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cmbAsignatura);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNotaS);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmbEstudiante);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtStudentId);
            panel1.Location = new Point(12, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(397, 272);
            panel1.TabIndex = 14;
            // 
            // txtnotaIIP
            // 
            txtnotaIIP.Location = new Point(145, 207);
            txtnotaIIP.Name = "txtnotaIIP";
            txtnotaIIP.Size = new Size(100, 23);
            txtnotaIIP.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(34, 215);
            label7.Name = "label7";
            label7.Size = new Size(95, 15);
            label7.TabIndex = 13;
            label7.Text = "Nota II Examen:";
            // 
            // txtnotaIP
            // 
            txtnotaIP.Location = new Point(145, 169);
            txtnotaIP.Name = "txtnotaIP";
            txtnotaIP.Size = new Size(100, 23);
            txtnotaIP.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(34, 177);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 11;
            label6.Text = "Nota I Examen:";
            // 
            // cmbAsignatura
            // 
            cmbAsignatura.FormattingEnabled = true;
            cmbAsignatura.Location = new Point(145, 88);
            cmbAsignatura.Name = "cmbAsignatura";
            cmbAsignatura.Size = new Size(121, 23);
            cmbAsignatura.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(73, 96);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 9;
            label3.Text = "Asignatura:";
            // 
            // txtNotaS
            // 
            txtNotaS.Location = new Point(145, 131);
            txtNotaS.Name = "txtNotaS";
            txtNotaS.Size = new Size(100, 23);
            txtNotaS.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(34, 139);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 7;
            label5.Text = "Nota Sistematicos:";
            // 
            // cmbEstudiante
            // 
            cmbEstudiante.FormattingEnabled = true;
            cmbEstudiante.Location = new Point(145, 50);
            cmbEstudiante.Name = "cmbEstudiante";
            cmbEstudiante.Size = new Size(121, 23);
            cmbEstudiante.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(74, 58);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 5;
            label4.Text = "Estudiante:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(39, 16);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 1;
            label2.Text = "Id de Calificacion:";
            // 
            // txtStudentId
            // 
            txtStudentId.Enabled = false;
            txtStudentId.Location = new Point(145, 9);
            txtStudentId.Margin = new Padding(3, 2, 3, 2);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(110, 23);
            txtStudentId.TabIndex = 2;
            // 
            // dgvCalificacion
            // 
            dgvCalificacion.AllowUserToAddRows = false;
            dgvCalificacion.AllowUserToDeleteRows = false;
            dgvCalificacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCalificacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalificacion.Location = new Point(12, 354);
            dgvCalificacion.Margin = new Padding(3, 2, 3, 2);
            dgvCalificacion.Name = "dgvCalificacion";
            dgvCalificacion.ReadOnly = true;
            dgvCalificacion.RowHeadersWidth = 51;
            dgvCalificacion.RowTemplate.Height = 29;
            dgvCalificacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCalificacion.Size = new Size(659, 147);
            dgvCalificacion.TabIndex = 13;
            dgvCalificacion.CellClick += dgvCalificacion_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(293, 30);
            label1.Name = "label1";
            label1.Size = new Size(203, 25);
            label1.TabIndex = 12;
            label1.Text = "Lista de Calificaciones";
            // 
            // txtNF
            // 
            txtNF.Location = new Point(145, 246);
            txtNF.Name = "txtNF";
            txtNF.Size = new Size(100, 23);
            txtNF.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(34, 254);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 15;
            label8.Text = "Nota Final:";
            // 
            // Calificacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 522);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvCalificacion);
            Controls.Add(label1);
            Name = "Calificacion";
            Text = "Calificacion";
            Load += Calificacion_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCalificacion).EndInit();
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
        private TextBox txtNotaS;
        private Label label5;
        private ComboBox cmbEstudiante;
        private Label label4;
        private Label label2;
        private TextBox txtStudentId;
        private DataGridView dgvCalificacion;
        private Label label1;
        private ComboBox cmbAsignatura;
        private Label label3;
        private TextBox txtnotaIIP;
        private Label label7;
        private TextBox txtnotaIP;
        private Label label6;
        private TextBox txtNF;
        private Label label8;
    }
}