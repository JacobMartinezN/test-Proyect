namespace pe.edu.upc.view
{
    partial class frmMulta
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
            this.btnListarMultas = new System.Windows.Forms.Button();
            this.dgvMulta = new System.Windows.Forms.DataGridView();
            this.FechaPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasMora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMulta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarMultas
            // 
            this.btnListarMultas.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarMultas.Location = new System.Drawing.Point(370, 402);
            this.btnListarMultas.Name = "btnListarMultas";
            this.btnListarMultas.Size = new System.Drawing.Size(88, 35);
            this.btnListarMultas.TabIndex = 13;
            this.btnListarMultas.Text = "Listar";
            this.btnListarMultas.UseVisualStyleBackColor = true;
            this.btnListarMultas.Click += new System.EventHandler(this.btnListarMultas_Click);
            // 
            // dgvMulta
            // 
            this.dgvMulta.AllowUserToAddRows = false;
            this.dgvMulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaPrestamo,
            this.DiasMora,
            this.CodigoUsuario,
            this.NombreUsuario,
            this.ApellidoUsuario,
            this.CorreoUsuario});
            this.dgvMulta.Location = new System.Drawing.Point(74, 72);
            this.dgvMulta.Name = "dgvMulta";
            this.dgvMulta.Size = new System.Drawing.Size(642, 311);
            this.dgvMulta.TabIndex = 12;
            // 
            // FechaPrestamo
            // 
            this.FechaPrestamo.DataPropertyName = "FechaPrestamo";
            this.FechaPrestamo.HeaderText = "FechaPrestamo";
            this.FechaPrestamo.Name = "FechaPrestamo";
            this.FechaPrestamo.ReadOnly = true;
            // 
            // DiasMora
            // 
            this.DiasMora.DataPropertyName = "DiasMora";
            this.DiasMora.HeaderText = "DiasMora";
            this.DiasMora.Name = "DiasMora";
            this.DiasMora.ReadOnly = true;
            // 
            // CodigoUsuario
            // 
            this.CodigoUsuario.DataPropertyName = "CodigoUsuario";
            this.CodigoUsuario.HeaderText = "Codigo";
            this.CodigoUsuario.Name = "CodigoUsuario";
            this.CodigoUsuario.ReadOnly = true;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.DataPropertyName = "NombreUsuario";
            this.NombreUsuario.HeaderText = "Nombre";
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.ReadOnly = true;
            // 
            // ApellidoUsuario
            // 
            this.ApellidoUsuario.DataPropertyName = "ApellidoUsuario";
            this.ApellidoUsuario.HeaderText = "Apellido";
            this.ApellidoUsuario.Name = "ApellidoUsuario";
            this.ApellidoUsuario.ReadOnly = true;
            // 
            // CorreoUsuario
            // 
            this.CorreoUsuario.DataPropertyName = "CorreoUsuario";
            this.CorreoUsuario.HeaderText = "Correo";
            this.CorreoUsuario.Name = "CorreoUsuario";
            this.CorreoUsuario.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(760, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = " Información de Multas                                                           " +
    "            ";
            // 
            // frmMulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListarMultas);
            this.Controls.Add(this.dgvMulta);
            this.Controls.Add(this.label8);
            this.Name = "frmMulta";
            this.Text = "frmMulta";
            this.Load += new System.EventHandler(this.frmMulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarMultas;
        private System.Windows.Forms.DataGridView dgvMulta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasMora;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoUsuario;
    }
}