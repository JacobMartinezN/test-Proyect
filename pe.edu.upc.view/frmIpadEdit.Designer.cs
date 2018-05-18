namespace pe.edu.upc.view
{
    partial class frmIpadEdit
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnGuardarIpad = new System.Windows.Forms.Button();
            this.cbEstadoIpad = new System.Windows.Forms.ComboBox();
            this.txtVersioIpad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(768, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "Actualización de Ipads                                                           " +
    "              ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.btnGuardarIpad);
            this.groupBox1.Controls.Add(this.cbEstadoIpad);
            this.groupBox1.Controls.Add(this.txtVersioIpad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 287);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(105, 77);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(299, 78);
            this.txtDescription.TabIndex = 18;
            // 
            // btnGuardarIpad
            // 
            this.btnGuardarIpad.Location = new System.Drawing.Point(23, 234);
            this.btnGuardarIpad.Name = "btnGuardarIpad";
            this.btnGuardarIpad.Size = new System.Drawing.Size(173, 33);
            this.btnGuardarIpad.TabIndex = 17;
            this.btnGuardarIpad.Text = "Guardar Cambios";
            this.btnGuardarIpad.UseVisualStyleBackColor = true;
            this.btnGuardarIpad.Click += new System.EventHandler(this.btnGuardarIpad_Click);
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
            // txtVersioIpad
            // 
            this.txtVersioIpad.Location = new System.Drawing.Point(101, 28);
            this.txtVersioIpad.Name = "txtVersioIpad";
            this.txtVersioIpad.Size = new System.Drawing.Size(303, 26);
            this.txtVersioIpad.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 34);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción:";
            // 
            // frmIpadEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 357);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Name = "frmIpadEdit";
            this.Text = "frmIpadEdit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnGuardarIpad;
        private System.Windows.Forms.ComboBox cbEstadoIpad;
        private System.Windows.Forms.TextBox txtVersioIpad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}