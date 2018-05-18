namespace pe.edu.upc.view
{
    partial class frmMovimientoUsuario
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
            this.btnEliminarMovi = new System.Windows.Forms.Button();
            this.gvMovimientoUs = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFechaPrestamoUsuario = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrarMovimiento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaPréstamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDevolución = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ipad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvMovimientoUs)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminarMovi
            // 
            this.btnEliminarMovi.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMovi.Location = new System.Drawing.Point(354, 519);
            this.btnEliminarMovi.Name = "btnEliminarMovi";
            this.btnEliminarMovi.Size = new System.Drawing.Size(122, 33);
            this.btnEliminarMovi.TabIndex = 24;
            this.btnEliminarMovi.Text = "Eliminar";
            this.btnEliminarMovi.UseVisualStyleBackColor = true;
            // 
            // gvMovimientoUs
            // 
            this.gvMovimientoUs.AllowUserToAddRows = false;
            this.gvMovimientoUs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMovimientoUs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaPréstamo,
            this.FechaDevolución,
            this.Ipad,
            this.Usuario,
            this.Estado});
            this.gvMovimientoUs.Location = new System.Drawing.Point(23, 233);
            this.gvMovimientoUs.Name = "gvMovimientoUs";
            this.gvMovimientoUs.Size = new System.Drawing.Size(740, 270);
            this.gvMovimientoUs.TabIndex = 23;
            this.gvMovimientoUs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMovimientoUs_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(761, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Reserva de Ipads                                                                 " +
    "                ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCodigoUsuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtFechaPrestamoUsuario);
            this.groupBox1.Controls.Add(this.btnRegistrarMovimiento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 146);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reserva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "El préstamo del recurso vence en tres días.";
            // 
            // txtCodigoUsuario
            // 
            this.txtCodigoUsuario.Location = new System.Drawing.Point(142, 81);
            this.txtCodigoUsuario.Name = "txtCodigoUsuario";
            this.txtCodigoUsuario.Size = new System.Drawing.Size(179, 26);
            this.txtCodigoUsuario.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Código Usuario:";
            // 
            // dtFechaPrestamoUsuario
            // 
            this.dtFechaPrestamoUsuario.Location = new System.Drawing.Point(142, 33);
            this.dtFechaPrestamoUsuario.Name = "dtFechaPrestamoUsuario";
            this.dtFechaPrestamoUsuario.Size = new System.Drawing.Size(211, 26);
            this.dtFechaPrestamoUsuario.TabIndex = 18;
            // 
            // btnRegistrarMovimiento
            // 
            this.btnRegistrarMovimiento.Location = new System.Drawing.Point(468, 77);
            this.btnRegistrarMovimiento.Name = "btnRegistrarMovimiento";
            this.btnRegistrarMovimiento.Size = new System.Drawing.Size(122, 33);
            this.btnRegistrarMovimiento.TabIndex = 14;
            this.btnRegistrarMovimiento.Text = "Registrar";
            this.btnRegistrarMovimiento.UseVisualStyleBackColor = true;
            this.btnRegistrarMovimiento.Click += new System.EventHandler(this.btnRegistrarMovimiento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Préstamo:";
            // 
            // FechaPréstamo
            // 
            this.FechaPréstamo.DataPropertyName = "FechaPrestamo";
            this.FechaPréstamo.HeaderText = "FechaPréstamo";
            this.FechaPréstamo.Name = "FechaPréstamo";
            this.FechaPréstamo.Width = 145;
            // 
            // FechaDevolución
            // 
            this.FechaDevolución.DataPropertyName = "FechaDevolucion";
            this.FechaDevolución.HeaderText = "FechaDevolución";
            this.FechaDevolución.Name = "FechaDevolución";
            this.FechaDevolución.Width = 145;
            // 
            // Ipad
            // 
            this.Ipad.DataPropertyName = "IpadCodigo";
            this.Ipad.HeaderText = "Ipad";
            this.Ipad.Name = "Ipad";
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "UsuarioCodigo";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "EstadoMovimiento";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // frmMovimientoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.btnEliminarMovi);
            this.Controls.Add(this.gvMovimientoUs);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMovimientoUsuario";
            this.Text = "MovimientoUsuario";
            this.Load += new System.EventHandler(this.frmMovimientoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvMovimientoUs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarMovi;
        private System.Windows.Forms.DataGridView gvMovimientoUs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFechaPrestamoUsuario;
        private System.Windows.Forms.Button btnRegistrarMovimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPréstamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDevolución;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ipad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}