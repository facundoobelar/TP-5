namespace ejercicio6
{
    partial class Inicio
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
            this.acreditarSaldo = new System.Windows.Forms.Button();
            this.debitar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.consultarSaldo = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // acreditarSaldo
            // 
            this.acreditarSaldo.Location = new System.Drawing.Point(3, 3);
            this.acreditarSaldo.Name = "acreditarSaldo";
            this.acreditarSaldo.Size = new System.Drawing.Size(94, 23);
            this.acreditarSaldo.TabIndex = 1;
            this.acreditarSaldo.Text = "Acreditar Saldo";
            this.acreditarSaldo.UseVisualStyleBackColor = true;
            this.acreditarSaldo.Click += new System.EventHandler(this.acreditarSaldo_Click);
            // 
            // debitar
            // 
            this.debitar.Location = new System.Drawing.Point(103, 3);
            this.debitar.Name = "debitar";
            this.debitar.Size = new System.Drawing.Size(94, 23);
            this.debitar.TabIndex = 0;
            this.debitar.Text = "Debitar";
            this.debitar.UseVisualStyleBackColor = true;
            this.debitar.Click += new System.EventHandler(this.debitar_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.acreditarSaldo);
            this.flowLayoutPanel1.Controls.Add(this.debitar);
            this.flowLayoutPanel1.Controls.Add(this.consultarSaldo);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 60);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // consultarSaldo
            // 
            this.consultarSaldo.Location = new System.Drawing.Point(3, 32);
            this.consultarSaldo.Name = "consultarSaldo";
            this.consultarSaldo.Size = new System.Drawing.Size(94, 23);
            this.consultarSaldo.TabIndex = 2;
            this.consultarSaldo.Text = "Consultar saldo";
            this.consultarSaldo.UseVisualStyleBackColor = true;
            this.consultarSaldo.Click += new System.EventHandler(this.consultarSaldo_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(103, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(68, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 108);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 204);
            this.Controls.Add(this.groupBox1);
            this.Name = "Inicio";
            this.Text = "Iniciar tramite";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button acreditarSaldo;
        private System.Windows.Forms.Button debitar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button consultarSaldo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

