namespace EnviarMail_net_Core
{
    partial class EnvioCorreoGmail
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
            this.correo = new System.Windows.Forms.TextBox();
            this.enviar = new System.Windows.Forms.Button();
            this.asunto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cuerpo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // correo
            // 
            this.correo.Location = new System.Drawing.Point(60, 11);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(409, 20);
            this.correo.TabIndex = 0;
            // 
            // enviar
            // 
            this.enviar.Location = new System.Drawing.Point(475, 8);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(111, 62);
            this.enviar.TabIndex = 1;
            this.enviar.Text = "enviar";
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // asunto
            // 
            this.asunto.Location = new System.Drawing.Point(60, 50);
            this.asunto.Name = "asunto";
            this.asunto.Size = new System.Drawing.Size(409, 20);
            this.asunto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Correo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Asunto: ";
            // 
            // cuerpo
            // 
            this.cuerpo.Location = new System.Drawing.Point(15, 102);
            this.cuerpo.Multiline = true;
            this.cuerpo.Name = "cuerpo";
            this.cuerpo.Size = new System.Drawing.Size(571, 152);
            this.cuerpo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripcion:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 266);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cuerpo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.asunto);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.correo);
            this.Name = "Form1";
            this.Text = "Envio de Correo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.TextBox asunto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cuerpo;
        private System.Windows.Forms.Label label3;
    }
}

