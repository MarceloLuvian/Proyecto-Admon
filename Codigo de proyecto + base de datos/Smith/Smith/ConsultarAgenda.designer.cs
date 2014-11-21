namespace SmithyAsociados
{
    partial class ConsultarAgenda
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
            this.dataAgendas = new System.Windows.Forms.DataGridView();
            this.lblBienbenida = new System.Windows.Forms.Label();
            this.btnRegresarPrincipal = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataAgendas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataAgendas
            // 
            this.dataAgendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAgendas.Location = new System.Drawing.Point(32, 44);
            this.dataAgendas.Name = "dataAgendas";
            this.dataAgendas.Size = new System.Drawing.Size(610, 271);
            this.dataAgendas.TabIndex = 0;
            this.dataAgendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblBienbenida
            // 
            this.lblBienbenida.AutoSize = true;
            this.lblBienbenida.Location = new System.Drawing.Point(211, 9);
            this.lblBienbenida.Name = "lblBienbenida";
            this.lblBienbenida.Size = new System.Drawing.Size(0, 13);
            this.lblBienbenida.TabIndex = 1;
            // 
            // btnRegresarPrincipal
            // 
            this.btnRegresarPrincipal.Location = new System.Drawing.Point(172, 385);
            this.btnRegresarPrincipal.Name = "btnRegresarPrincipal";
            this.btnRegresarPrincipal.Size = new System.Drawing.Size(141, 36);
            this.btnRegresarPrincipal.TabIndex = 2;
            this.btnRegresarPrincipal.Text = "Regresar";
            this.btnRegresarPrincipal.UseVisualStyleBackColor = true;
            this.btnRegresarPrincipal.Click += new System.EventHandler(this.btnRegresarPrincipal_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Agregar o Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.dataAgendas);
            this.groupBox1.Location = new System.Drawing.Point(22, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 346);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de consulta";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ConsultarAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(727, 460);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRegresarPrincipal);
            this.Controls.Add(this.lblBienbenida);
            this.Name = "ConsultarAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarAgenda";
            this.Load += new System.EventHandler(this.ConsultarAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAgendas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataAgendas;
        private System.Windows.Forms.Label lblBienbenida;
        private System.Windows.Forms.Button btnRegresarPrincipal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}