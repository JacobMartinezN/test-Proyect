namespace pe.edu.upc.view
{
    partial class frmAlumno
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
            this.gvUsuario = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFacultadUS = new System.Windows.Forms.ComboBox();
            this.cbSedeUs = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelefonoUs = new System.Windows.Forms.TextBox();
            this.btnRegUsu = new System.Windows.Forms.Button();
            this.txtDNIUs = new System.Windows.Forms.TextBox();
            this.txtCorreoUs = new System.Windows.Forms.TextBox();
            this.txtCodigoUs = new System.Windows.Forms.TextBox();
            this.txtApellidoUs = new System.Windows.Forms.TextBox();
            this.txtNombreUs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Facultad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsuario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvUsuario
            // 
            this.gvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Apellido,
            this.Facultad,
            this.Sede,
            this.Correo});
            this.gvUsuario.Location = new System.Drawing.Point(17, 308);
            this.gvUsuario.Name = "gvUsuario";
            this.gvUsuario.Size = new System.Drawing.Size(739, 270);
            this.gvUsuario.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(755, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = " Información de Alumno                                                           " +
    "          ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFacultadUS);
            this.groupBox1.Controls.Add(this.cbSedeUs);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTelefonoUs);
            this.groupBox1.Controls.Add(this.btnRegUsu);
            this.groupBox1.Controls.Add(this.txtDNIUs);
            this.groupBox1.Controls.Add(this.txtCorreoUs);
            this.groupBox1.Controls.Add(this.txtCodigoUs);
            this.groupBox1.Controls.Add(this.txtApellidoUs);
            this.groupBox1.Controls.Add(this.txtNombreUs);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 246);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            // 
            // txtFacultadUS
            // 
            this.txtFacultadUS.FormattingEnabled = true;
            this.txtFacultadUS.Items.AddRange(new object[] {
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
            this.txtFacultadUS.Location = new System.Drawing.Point(86, 113);
            this.txtFacultadUS.Name = "txtFacultadUS";
            this.txtFacultadUS.Size = new System.Drawing.Size(318, 26);
            this.txtFacultadUS.TabIndex = 18;
            // 
            // cbSedeUs
            // 
            this.cbSedeUs.FormattingEnabled = true;
            this.cbSedeUs.Location = new System.Drawing.Point(497, 113);
            this.cbSedeUs.Name = "cbSedeUs";
            this.cbSedeUs.Size = new System.Drawing.Size(145, 26);
            this.cbSedeUs.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(445, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 14);
            this.label9.TabIndex = 16;
            this.label9.Text = "Teléf. :";
            // 
            // txtTelefonoUs
            // 
            this.txtTelefonoUs.Location = new System.Drawing.Point(497, 146);
            this.txtTelefonoUs.Name = "txtTelefonoUs";
            this.txtTelefonoUs.Size = new System.Drawing.Size(145, 26);
            this.txtTelefonoUs.TabIndex = 15;
            // 
            // btnRegUsu
            // 
            this.btnRegUsu.Location = new System.Drawing.Point(296, 196);
            this.btnRegUsu.Name = "btnRegUsu";
            this.btnRegUsu.Size = new System.Drawing.Size(145, 33);
            this.btnRegUsu.TabIndex = 14;
            this.btnRegUsu.Text = "Registrar";
            this.btnRegUsu.UseVisualStyleBackColor = true;
            this.btnRegUsu.Click += new System.EventHandler(this.btnRegUsu_Click);
            // 
            // txtDNIUs
            // 
            this.txtDNIUs.Location = new System.Drawing.Point(497, 70);
            this.txtDNIUs.Name = "txtDNIUs";
            this.txtDNIUs.Size = new System.Drawing.Size(145, 26);
            this.txtDNIUs.TabIndex = 12;
            // 
            // txtCorreoUs
            // 
            this.txtCorreoUs.Location = new System.Drawing.Point(86, 151);
            this.txtCorreoUs.Name = "txtCorreoUs";
            this.txtCorreoUs.Size = new System.Drawing.Size(318, 26);
            this.txtCorreoUs.TabIndex = 11;
            // 
            // txtCodigoUs
            // 
            this.txtCodigoUs.Location = new System.Drawing.Point(497, 33);
            this.txtCodigoUs.Name = "txtCodigoUs";
            this.txtCodigoUs.Size = new System.Drawing.Size(145, 26);
            this.txtCodigoUs.TabIndex = 9;
            // 
            // txtApellidoUs
            // 
            this.txtApellidoUs.Location = new System.Drawing.Point(86, 76);
            this.txtApellidoUs.Name = "txtApellidoUs";
            this.txtApellidoUs.Size = new System.Drawing.Size(318, 26);
            this.txtApellidoUs.TabIndex = 8;
            // 
            // txtNombreUs
            // 
            this.txtNombreUs.Location = new System.Drawing.Point(86, 33);
            this.txtNombreUs.Name = "txtNombreUs";
            this.txtNombreUs.Size = new System.Drawing.Size(318, 26);
            this.txtNombreUs.TabIndex = 7;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(445, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sede:";
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
            // Sede
            // 
            this.Sede.DataPropertyName = "Sede";
            this.Sede.HeaderText = "Sede";
            this.Sede.Name = "Sede";
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            // 
            // frmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 586);
            this.Controls.Add(this.gvUsuario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAlumno";
            this.Text = "frmUsuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvUsuario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtFacultadUS;
        private System.Windows.Forms.ComboBox cbSedeUs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelefonoUs;
        private System.Windows.Forms.Button btnRegUsu;
        private System.Windows.Forms.TextBox txtDNIUs;
        private System.Windows.Forms.TextBox txtCorreoUs;
        private System.Windows.Forms.TextBox txtCodigoUs;
        private System.Windows.Forms.TextBox txtApellidoUs;
        private System.Windows.Forms.TextBox txtNombreUs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Facultad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sede;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
    }
}