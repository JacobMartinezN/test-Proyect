namespace pe.edu.upc.view
{
    partial class frmMovimientoDevolucion
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
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.gvDevolucion = new System.Windows.Forms.DataGridView();
            this.FechaPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDevolucionReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IpadCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BibliotecarioCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDevolucion)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Devolucion de Ipads";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtFechaDevolucion);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 192);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Devolucion";
            // 
            // dtFechaDevolucion
            // 
            this.dtFechaDevolucion.Location = new System.Drawing.Point(200, 30);
            this.dtFechaDevolucion.Name = "dtFechaDevolucion";
            this.dtFechaDevolucion.Size = new System.Drawing.Size(211, 26);
            this.dtFechaDevolucion.TabIndex = 18;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(489, 133);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(122, 33);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de Devolucion Real";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Codigo de Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(200, 88);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(179, 26);
            this.txtUsuario.TabIndex = 27;
            // 
            // gvDevolucion
            // 
            this.gvDevolucion.AllowUserToAddRows = false;
            this.gvDevolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDevolucion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaPrestamo,
            this.FechaDevolucionReal,
            this.IpadCodigo,
            this.UsuarioCodigo,
            this.BibliotecarioCodigo,
            this.EstadoMovimiento});
            this.gvDevolucion.Location = new System.Drawing.Point(16, 283);
            this.gvDevolucion.Name = "gvDevolucion";
            this.gvDevolucion.Size = new System.Drawing.Size(739, 270);
            this.gvDevolucion.TabIndex = 24;
            // 
            // FechaPrestamo
            // 
            this.FechaPrestamo.DataPropertyName = "FechaPrestamo";
            this.FechaPrestamo.HeaderText = "FechaPréstamo";
            this.FechaPrestamo.Name = "FechaPrestamo";
            this.FechaPrestamo.Width = 145;
            // 
            // FechaDevolucionReal
            // 
            this.FechaDevolucionReal.DataPropertyName = "FechaDevolucionReal";
            this.FechaDevolucionReal.HeaderText = "FechaDevolucionReal";
            this.FechaDevolucionReal.Name = "FechaDevolucionReal";
            this.FechaDevolucionReal.Width = 145;
            // 
            // IpadCodigo
            // 
            this.IpadCodigo.DataPropertyName = "IpadCodigo";
            this.IpadCodigo.HeaderText = "Ipad";
            this.IpadCodigo.Name = "IpadCodigo";
            // 
            // UsuarioCodigo
            // 
            this.UsuarioCodigo.DataPropertyName = "UsuarioCodigo";
            this.UsuarioCodigo.HeaderText = "Usuario";
            this.UsuarioCodigo.Name = "UsuarioCodigo";
            // 
            // BibliotecarioCodigo
            // 
            this.BibliotecarioCodigo.DataPropertyName = "BibliotecarioCodigo";
            this.BibliotecarioCodigo.HeaderText = "Bibliotecario";
            this.BibliotecarioCodigo.Name = "BibliotecarioCodigo";
            // 
            // EstadoMovimiento
            // 
            this.EstadoMovimiento.DataPropertyName = "EstadoMovimiento";
            this.EstadoMovimiento.HeaderText = "Estado";
            this.EstadoMovimiento.Name = "EstadoMovimiento";
            // 
            // frmMovimientoDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 620);
            this.Controls.Add(this.gvDevolucion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Name = "frmMovimientoDevolucion";
            this.Text = "frmMovimientoDevolucion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDevolucion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtFechaDevolucion;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gvDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDevolucionReal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IpadCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BibliotecarioCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoMovimiento;
    }
}