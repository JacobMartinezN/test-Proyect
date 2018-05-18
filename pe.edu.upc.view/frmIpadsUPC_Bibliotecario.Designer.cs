namespace pe.edu.upc.view
{
    partial class frmIpadsUPC_Bibliotecario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ipadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administDeIpadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sedesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarMultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudDePrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administDePrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionDePrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 594);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(801, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.ipadsToolStripMenuItem,
            this.admToolStripMenuItem,
            this.sedesToolStripMenuItem,
            this.multasToolStripMenuItem,
            this.movimientosToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(801, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "MenuStrip";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarAlumnoToolStripMenuItem,
            this.registrarDocenteToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuarioToolStripMenuItem.Text = "Usuarios";
            // 
            // registrarAlumnoToolStripMenuItem
            // 
            this.registrarAlumnoToolStripMenuItem.Name = "registrarAlumnoToolStripMenuItem";
            this.registrarAlumnoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.registrarAlumnoToolStripMenuItem.Text = "Registrar Alumno";
            this.registrarAlumnoToolStripMenuItem.Click += new System.EventHandler(this.registrarAlumnoToolStripMenuItem_Click);
            // 
            // registrarDocenteToolStripMenuItem
            // 
            this.registrarDocenteToolStripMenuItem.Name = "registrarDocenteToolStripMenuItem";
            this.registrarDocenteToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.registrarDocenteToolStripMenuItem.Text = "Registrar Docente";
            this.registrarDocenteToolStripMenuItem.Click += new System.EventHandler(this.registrarDocenteToolStripMenuItem_Click);
            // 
            // ipadsToolStripMenuItem
            // 
            this.ipadsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administDeIpadsToolStripMenuItem});
            this.ipadsToolStripMenuItem.Name = "ipadsToolStripMenuItem";
            this.ipadsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.ipadsToolStripMenuItem.Text = "Ipads";
            // 
            // administDeIpadsToolStripMenuItem
            // 
            this.administDeIpadsToolStripMenuItem.Name = "administDeIpadsToolStripMenuItem";
            this.administDeIpadsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.administDeIpadsToolStripMenuItem.Text = "Administ. de Ipads";
            this.administDeIpadsToolStripMenuItem.Click += new System.EventHandler(this.administDeIpadsToolStripMenuItem_Click);
            // 
            // admToolStripMenuItem
            // 
            this.admToolStripMenuItem.Name = "admToolStripMenuItem";
            this.admToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.admToolStripMenuItem.Text = "Bibliotecarios";
            // 
            // sedesToolStripMenuItem
            // 
            this.sedesToolStripMenuItem.Name = "sedesToolStripMenuItem";
            this.sedesToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sedesToolStripMenuItem.Text = "Sedes";
            // 
            // multasToolStripMenuItem
            // 
            this.multasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarMultasToolStripMenuItem});
            this.multasToolStripMenuItem.Name = "multasToolStripMenuItem";
            this.multasToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.multasToolStripMenuItem.Text = "Multas";
            // 
            // listarMultasToolStripMenuItem
            // 
            this.listarMultasToolStripMenuItem.Name = "listarMultasToolStripMenuItem";
            this.listarMultasToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.listarMultasToolStripMenuItem.Text = "Listar Multas";
            this.listarMultasToolStripMenuItem.Click += new System.EventHandler(this.listarMultasToolStripMenuItem_Click);
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solicitudDePrestamoToolStripMenuItem,
            this.administDePrestamoToolStripMenuItem,
            this.devolucionDePrestamoToolStripMenuItem});
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.movimientosToolStripMenuItem.Text = "Movimientos";
            // 
            // solicitudDePrestamoToolStripMenuItem
            // 
            this.solicitudDePrestamoToolStripMenuItem.Name = "solicitudDePrestamoToolStripMenuItem";
            this.solicitudDePrestamoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.solicitudDePrestamoToolStripMenuItem.Text = "Solicitud de Prestamo";
            this.solicitudDePrestamoToolStripMenuItem.Click += new System.EventHandler(this.solicitudDePrestamoToolStripMenuItem_Click);
            // 
            // administDePrestamoToolStripMenuItem
            // 
            this.administDePrestamoToolStripMenuItem.Name = "administDePrestamoToolStripMenuItem";
            this.administDePrestamoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.administDePrestamoToolStripMenuItem.Text = "Administ. de Prestamo";
            this.administDePrestamoToolStripMenuItem.Click += new System.EventHandler(this.administDePrestamoToolStripMenuItem_Click);
            // 
            // devolucionDePrestamoToolStripMenuItem
            // 
            this.devolucionDePrestamoToolStripMenuItem.Name = "devolucionDePrestamoToolStripMenuItem";
            this.devolucionDePrestamoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.devolucionDePrestamoToolStripMenuItem.Text = "Devolucion de Prestamo";
            this.devolucionDePrestamoToolStripMenuItem.Click += new System.EventHandler(this.devolucionDePrestamoToolStripMenuItem_Click);
            // 
            // frmIpadsUPC_Bibliotecario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 616);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.Name = "frmIpadsUPC_Bibliotecario";
            this.Text = "frmIpadsUPC_Bibliotecario";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ipadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem admToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sedesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarMultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administDeIpadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudDePrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administDePrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolucionDePrestamoToolStripMenuItem;
    }
}



