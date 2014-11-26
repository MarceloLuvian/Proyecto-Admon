namespace SmithyAsociados
{
    partial class Principal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCAgenda = new System.Windows.Forms.Button();
            this.btnMAgenda = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnCAgenda);
            this.groupBox1.Controls.Add(this.btnMAgenda);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 382);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // btnCAgenda
            // 
            this.btnCAgenda.Location = new System.Drawing.Point(50, 97);
            this.btnCAgenda.Name = "btnCAgenda";
            this.btnCAgenda.Size = new System.Drawing.Size(115, 38);
            this.btnCAgenda.TabIndex = 3;
            this.btnCAgenda.Text = "Consultar agenda";
            this.btnCAgenda.UseVisualStyleBackColor = true;
            this.btnCAgenda.Click += new System.EventHandler(this.btnCAgenda_Click);
            // 
            // btnMAgenda
            // 
            this.btnMAgenda.Location = new System.Drawing.Point(50, 39);
            this.btnMAgenda.Name = "btnMAgenda";
            this.btnMAgenda.Size = new System.Drawing.Size(115, 38);
            this.btnMAgenda.TabIndex = 1;
            this.btnMAgenda.Text = "Modificar agenda";
            this.btnMAgenda.UseVisualStyleBackColor = true;
            this.btnMAgenda.Click += new System.EventHandler(this.btnMAgenda_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(724, 378);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(115, 38);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(851, 428);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.groupBox1);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCAgenda;
        private System.Windows.Forms.Button btnMAgenda;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}