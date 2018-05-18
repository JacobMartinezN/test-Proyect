namespace pe.edu.upc.view
{
    partial class frmDocente
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
            this.dgvDocente = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Facultad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFacultadDocente = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelefonoDocente = new System.Windows.Forms.TextBox();
            this.btnRegDocente = new System.Windows.Forms.Button();
            this.txtDNIDocente = new System.Windows.Forms.TextBox();
            this.txtCorreoDocente = new System.Windows.Forms.TextBox();
            this.txtCodigoDocente = new System.Windows.Forms.TextBox();
            this.txtApellidoDocente = new System.Windows.Forms.TextBox();
            this.txtNombreDocente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDocente
            // 
            this.dgvDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Apellido,
            this.Facultad,
            this.Correo});
            this.dgvDocente.Location = new System.Drawing.Point(26, 308);
            this.dgvDocente.Name = "dgvDocente";
            this.dgvDocente.Size = new System.Drawing.Size(739, 270);
            this.dgvDocente.TabIndex = 9;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Facultad
            // 
            this.Facultad.DataPropertyName = "Facultad";
            this.Facultad.HeaderText = "Facultad";
            this.Facultad.Name = "Facultad";
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(750, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = " Información de Docente                                                          " +
    "          ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFacultadDocente);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTelefonoDocente);
            this.groupBox1.Controls.Add(this.btnRegDocente);
            this.groupBox1.Controls.Add(this.txtDNIDocente);
            this.groupBox1.Controls.Add(this.txtCorreoDocente);
            this.groupBox1.Controls.Add(this.txtCodigoDocente);
            this.groupBox1.Controls.Add(this.txtApellidoDocente);
            this.groupBox1.Controls.Add(this.txtNombreDocente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 246);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            // 
            // cmbFacultadDocente
            // 
            this.cmbFacultadDocente.FormattingEnabled = true;
            this.cmbFacultadDocente.Items.AddRange(new object[] {
            "Ingeniería ",
            "Comunicación",
            "Administración",
            "Arquitectura",
            "Artes Contemporáneas",
            "Ciencias de la Salud",
            "Ciencias Humanas",
            "Derecho",
            "Diseño",
            "Economía",
            "Negocios",
            "Psicología"});
            this.cmbFacultadDocente.Location = new System.Drawing.Point(86, 113);
            this.cmbFacultadDocente.Name = "cmbFacultadDocente";
            this.cmbFacultadDocente.Size = new System.Drawing.Size(318, 26);
            this.cmbFacultadDocente.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(440, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 14);
            this.label9.TabIndex = 16;
            this.label9.Text = "Teléf. :";
            // 
            // txtTelefonoDocente
            // 
            this.txtTelefonoDocente.Location = new System.Drawing.Point(497, 113);
            this.txtTelefonoDocente.Name = "txtTelefonoDocente";
            this.txtTelefonoDocente.Size = new System.Drawing.Size(145, 26);
            this.txtTelefonoDocente.TabIndex = 15;
            // 
            // btnRegDocente
            // 
            this.btnRegDocente.Location = new System.Drawing.Point(296, 196);
            this.btnRegDocente.Name = "btnRegDocente";
            this.btnRegDocente.Size = new System.Drawing.Size(145, 33);
            this.btnRegDocente.TabIndex = 14;
            this.btnRegDocente.Text = "Registrar";
            this.btnRegDocente.UseVisualStyleBackColor = true;
            this.btnRegDocente.Click += new System.EventHandler(this.btnRegDocente_Click);
            // 
            // txtDNIDocente
            // 
            this.txtDNIDocente.Location = new System.Drawing.Point(497, 70);
            this.txtDNIDocente.Name = "txtDNIDocente";
            this.txtDNIDocente.Size = new System.Drawing.Size(145, 26);
            this.txtDNIDocente.TabIndex = 12;
            // 
            // txtCorreoDocente
            // 
            this.txtCorreoDocente.Location = new System.Drawing.Point(86, 151);
            this.txtCorreoDocente.Name = "txtCorreoDocente";
            this.txtCorreoDocente.Size = new System.Drawing.Size(318, 26);
            this.txtCorreoDocente.TabIndex = 11;
            // 
            // txtCodigoDocente
            // 
            this.txtCodigoDocente.Location = new System.Drawing.Point(497, 33);
            this.txtCodigoDocente.Name = "txtCodigoDocente";
            this.txtCodigoDocente.Size = new System.Drawing.Size(145, 26);
            this.txtCodigoDocente.TabIndex = 9;
            // 
            // txtApellidoDocente
            // 
            this.txtApellidoDocente.Location = new System.Drawing.Point(86, 76);
            this.txtApellidoDocente.Name = "txtApellidoDocente";
            this.txtApellidoDocente.Size = new System.Drawing.Size(318, 26);
            this.txtApellidoDocente.TabIndex = 8;
            // 
            // txtNombreDocente
            // 
            this.txtNombreDocente.Location = new System.Drawing.Point(86, 33);
            this.txtNombreDocente.Name = "txtNombreDocente";
            this.txtNombreDocente.Size = new System.Drawing.Size(318, 26);
            this.txtNombreDocente.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "Correo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(445, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Facultad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(437, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // frmDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 525);
            this.Controls.Add(this.dgvDocente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDocente";
            this.Text = "frmDocente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDocente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbFacultadDocente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelefonoDocente;
        private System.Windows.Forms.Button btnRegDocente;
        private System.Windows.Forms.TextBox txtDNIDocente;
        private System.Windows.Forms.TextBox txtCorreoDocente;
        private System.Windows.Forms.TextBox txtCodigoDocente;
        private System.Windows.Forms.TextBox txtApellidoDocente;
        private System.Windows.Forms.TextBox txtNombreDocente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Facultad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
    }
}