namespace pe.edu.upc.view
{
    partial class frmMovimiento
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
            this.gvMovimiento = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIpadCod = new System.Windows.Forms.TextBox();
            this.txtBibliotecarioCod = new System.Windows.Forms.TextBox();
            this.txtUsuarioCod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEstadoMov = new System.Windows.Forms.ComboBox();
            this.dtFechaDevo = new System.Windows.Forms.DateTimePicker();
            this.dtFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.btnRegMov = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IpadCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BibliotecarioCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvMovimiento)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvMovimiento
            // 
            this.gvMovimiento.AllowUserToAddRows = false;
            this.gvMovimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMovimiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaPrestamo,
            this.FechaDevolucion,
            this.IpadCodigo,
            this.UsuarioCodigo,
            this.BibliotecarioCodigo,
            this.EstadoMovimiento});
            this.gvMovimiento.Location = new System.Drawing.Point(24, 307);
            this.gvMovimiento.Name = "gvMovimiento";
            this.gvMovimiento.Size = new System.Drawing.Size(739, 270);
            this.gvMovimiento.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(746, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = " Información de Movimientos                                                      " +
    "     ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIpadCod);
            this.groupBox1.Controls.Add(this.txtBibliotecarioCod);
            this.groupBox1.Controls.Add(this.txtUsuarioCod);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbEstadoMov);
            this.groupBox1.Controls.Add(this.dtFechaDevo);
            this.groupBox1.Controls.Add(this.dtFechaPrestamo);
            this.groupBox1.Controls.Add(this.btnRegMov);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 221);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            // 
            // txtIpadCod
            // 
            this.txtIpadCod.Location = new System.Drawing.Point(157, 74);
            this.txtIpadCod.Name = "txtIpadCod";
            this.txtIpadCod.Size = new System.Drawing.Size(179, 26);
            this.txtIpadCod.TabIndex = 27;
            // 
            // txtBibliotecarioCod
            // 
            this.txtBibliotecarioCod.Location = new System.Drawing.Point(157, 163);
            this.txtBibliotecarioCod.Name = "txtBibliotecarioCod";
            this.txtBibliotecarioCod.Size = new System.Drawing.Size(179, 26);
            this.txtBibliotecarioCod.TabIndex = 26;
            // 
            // txtUsuarioCod
            // 
            this.txtUsuarioCod.Location = new System.Drawing.Point(157, 119);
            this.txtUsuarioCod.Name = "txtUsuarioCod";
            this.txtUsuarioCod.Size = new System.Drawing.Size(179, 26);
            this.txtUsuarioCod.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Código Bibliotecario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Código Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Código Ipad:";
            // 
            // cbEstadoMov
            // 
            this.cbEstadoMov.FormattingEnabled = true;
            this.cbEstadoMov.Items.AddRange(new object[] {
            "Denegado",
            "Aprobado"});
            this.cbEstadoMov.Location = new System.Drawing.Point(497, 74);
            this.cbEstadoMov.Name = "cbEstadoMov";
            this.cbEstadoMov.Size = new System.Drawing.Size(135, 26);
            this.cbEstadoMov.TabIndex = 20;
            // 
            // dtFechaDevo
            // 
            this.dtFechaDevo.Location = new System.Drawing.Point(497, 30);
            this.dtFechaDevo.Name = "dtFechaDevo";
            this.dtFechaDevo.Size = new System.Drawing.Size(211, 26);
            this.dtFechaDevo.TabIndex = 19;
            // 
            // dtFechaPrestamo
            // 
            this.dtFechaPrestamo.Location = new System.Drawing.Point(142, 33);
            this.dtFechaPrestamo.Name = "dtFechaPrestamo";
            this.dtFechaPrestamo.Size = new System.Drawing.Size(211, 26);
            this.dtFechaPrestamo.TabIndex = 18;
            // 
            // btnRegMov
            // 
            this.btnRegMov.Location = new System.Drawing.Point(438, 156);
            this.btnRegMov.Name = "btnRegMov";
            this.btnRegMov.Size = new System.Drawing.Size(122, 33);
            this.btnRegMov.TabIndex = 14;
            this.btnRegMov.Text = "Registrar";
            this.btnRegMov.UseVisualStyleBackColor = true;
            this.btnRegMov.Click += new System.EventHandler(this.btnRegMov_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(375, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha Devolución:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(435, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado:";
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
            // FechaPrestamo
            // 
            this.FechaPrestamo.DataPropertyName = "FechaPrestamo";
            this.FechaPrestamo.HeaderText = "FechaPréstamo";
            this.FechaPrestamo.Name = "FechaPrestamo";
            this.FechaPrestamo.Width = 145;
            // 
            // FechaDevolucion
            // 
            this.FechaDevolucion.DataPropertyName = "FechaDevolucion";
            this.FechaDevolucion.HeaderText = "FechaDevolución";
            this.FechaDevolucion.Name = "FechaDevolucion";
            this.FechaDevolucion.Width = 145;
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
            // frmMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 638);
            this.Controls.Add(this.gvMovimiento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMovimiento";
            this.Text = "frmMovimiento";
            ((System.ComponentModel.ISupportInitialize)(this.gvMovimiento)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gvMovimiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIpadCod;
        private System.Windows.Forms.TextBox txtBibliotecarioCod;
        private System.Windows.Forms.TextBox txtUsuarioCod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEstadoMov;
        private System.Windows.Forms.DateTimePicker dtFechaDevo;
        private System.Windows.Forms.DateTimePicker dtFechaPrestamo;
        private System.Windows.Forms.Button btnRegMov;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IpadCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BibliotecarioCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoMovimiento;
    }
}