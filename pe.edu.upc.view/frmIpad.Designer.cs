namespace pe.edu.upc.view
{
    partial class frmIpad
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
            this.btnEliminarIpad = new System.Windows.Forms.Button();
            this.gvIpad = new System.Windows.Forms.DataGridView();
            this.IpadId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VersionSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SedeNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSede = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnActualizarIpad = new System.Windows.Forms.Button();
            this.cbEstadoIpad = new System.Windows.Forms.ComboBox();
            this.btnRegIpad = new System.Windows.Forms.Button();
            this.txtModeloIpad = new System.Windows.Forms.TextBox();
            this.txtSerialIpad = new System.Windows.Forms.TextBox();
            this.txtVersioIpad = new System.Windows.Forms.TextBox();
            this.txtCodigoIpad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvIpad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminarIpad
            // 
            this.btnEliminarIpad.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarIpad.Location = new System.Drawing.Point(337, 579);
            this.btnEliminarIpad.Name = "btnEliminarIpad";
            this.btnEliminarIpad.Size = new System.Drawing.Size(122, 33);
            this.btnEliminarIpad.TabIndex = 22;
            this.btnEliminarIpad.Text = "Eliminar";
            this.btnEliminarIpad.UseVisualStyleBackColor = true;
            this.btnEliminarIpad.Click += new System.EventHandler(this.btnEliminarIpad_Click);
            // 
            // gvIpad
            // 
            this.gvIpad.AllowUserToAddRows = false;
            this.gvIpad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvIpad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IpadId,
            this.Codigo,
            this.VersionSO,
            this.Serial,
            this.Estado,
            this.Modelo,
            this.Descripcion,
            this.SedeNombre});
            this.gvIpad.Location = new System.Drawing.Point(25, 349);
            this.gvIpad.Name = "gvIpad";
            this.gvIpad.Size = new System.Drawing.Size(743, 215);
            this.gvIpad.TabIndex = 21;
            // 
            // IpadId
            // 
            this.IpadId.DataPropertyName = "IpadId";
            this.IpadId.HeaderText = "Id";
            this.IpadId.Name = "IpadId";
            this.IpadId.ReadOnly = true;
            this.IpadId.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 70;
            // 
            // VersionSO
            // 
            this.VersionSO.DataPropertyName = "VersionSO";
            this.VersionSO.HeaderText = "VersiónSO";
            this.VersionSO.Name = "VersionSO";
            this.VersionSO.Width = 70;
            // 
            // Serial
            // 
            this.Serial.DataPropertyName = "Serial";
            this.Serial.HeaderText = "Serial";
            this.Serial.Name = "Serial";
            this.Serial.Width = 90;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Width = 80;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Modelo";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.Width = 90;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 200;
            // 
            // SedeNombre
            // 
            this.SedeNombre.DataPropertyName = "SedeNombre";
            this.SedeNombre.HeaderText = "Sede";
            this.SedeNombre.Name = "SedeNombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(760, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = " Información de Ipads                                                            " +
    "             ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSede);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.btnActualizarIpad);
            this.groupBox1.Controls.Add(this.cbEstadoIpad);
            this.groupBox1.Controls.Add(this.btnRegIpad);
            this.groupBox1.Controls.Add(this.txtModeloIpad);
            this.groupBox1.Controls.Add(this.txtSerialIpad);
            this.groupBox1.Controls.Add(this.txtVersioIpad);
            this.groupBox1.Controls.Add(this.txtCodigoIpad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 287);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            // 
            // cmbSede
            // 
            this.cmbSede.FormattingEnabled = true;
            this.cmbSede.Location = new System.Drawing.Point(497, 181);
            this.cmbSede.Name = "cmbSede";
            this.cmbSede.Size = new System.Drawing.Size(145, 26);
            this.cmbSede.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(435, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sede:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(105, 125);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(299, 78);
            this.txtDescription.TabIndex = 18;
            // 
            // btnActualizarIpad
            // 
            this.btnActualizarIpad.Location = new System.Drawing.Point(340, 230);
            this.btnActualizarIpad.Name = "btnActualizarIpad";
            this.btnActualizarIpad.Size = new System.Drawing.Size(122, 33);
            this.btnActualizarIpad.TabIndex = 17;
            this.btnActualizarIpad.Text = "Actualizar";
            this.btnActualizarIpad.UseVisualStyleBackColor = true;
            this.btnActualizarIpad.Click += new System.EventHandler(this.btnActualizarIpad_Click);
            // 
            // cbEstadoIpad
            // 
            this.cbEstadoIpad.FormattingEnabled = true;
            this.cbEstadoIpad.Items.AddRange(new object[] {
            "Disponible",
            "En uso"});
            this.cbEstadoIpad.Location = new System.Drawing.Point(497, 76);
            this.cbEstadoIpad.Name = "cbEstadoIpad";
            this.cbEstadoIpad.Size = new System.Drawing.Size(145, 26);
            this.cbEstadoIpad.TabIndex = 16;
            // 
            // btnRegIpad
            // 
            this.btnRegIpad.Location = new System.Drawing.Point(23, 230);
            this.btnRegIpad.Name = "btnRegIpad";
            this.btnRegIpad.Size = new System.Drawing.Size(122, 33);
            this.btnRegIpad.TabIndex = 14;
            this.btnRegIpad.Text = "Registrar";
            this.btnRegIpad.UseVisualStyleBackColor = true;
            this.btnRegIpad.Click += new System.EventHandler(this.btnRegIpad_Click);
            // 
            // txtModeloIpad
            // 
            this.txtModeloIpad.Location = new System.Drawing.Point(497, 113);
            this.txtModeloIpad.Name = "txtModeloIpad";
            this.txtModeloIpad.Size = new System.Drawing.Size(145, 26);
            this.txtModeloIpad.TabIndex = 10;
            // 
            // txtSerialIpad
            // 
            this.txtSerialIpad.Location = new System.Drawing.Point(497, 33);
            this.txtSerialIpad.Name = "txtSerialIpad";
            this.txtSerialIpad.Size = new System.Drawing.Size(145, 26);
            this.txtSerialIpad.TabIndex = 9;
            // 
            // txtVersioIpad
            // 
            this.txtVersioIpad.Location = new System.Drawing.Point(101, 76);
            this.txtVersioIpad.Name = "txtVersioIpad";
            this.txtVersioIpad.Size = new System.Drawing.Size(303, 26);
            this.txtVersioIpad.TabIndex = 8;
            // 
            // txtCodigoIpad
            // 
            this.txtCodigoIpad.Location = new System.Drawing.Point(101, 33);
            this.txtCodigoIpad.Name = "txtCodigoIpad";
            this.txtCodigoIpad.Size = new System.Drawing.Size(303, 26);
            this.txtCodigoIpad.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Versión SO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(435, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(435, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Serial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(435, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // frmIpad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 622);
            this.Controls.Add(this.btnEliminarIpad);
            this.Controls.Add(this.gvIpad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmIpad";
            this.Text = "frmIpad";
            ((System.ComponentModel.ISupportInitialize)(this.gvIpad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarIpad;
        private System.Windows.Forms.DataGridView gvIpad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnActualizarIpad;
        private System.Windows.Forms.ComboBox cbEstadoIpad;
        private System.Windows.Forms.Button btnRegIpad;
        private System.Windows.Forms.TextBox txtModeloIpad;
        private System.Windows.Forms.TextBox txtSerialIpad;
        private System.Windows.Forms.TextBox txtVersioIpad;
        private System.Windows.Forms.TextBox txtCodigoIpad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSede;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn IpadId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VersionSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn SedeNombre;
    }
}