namespace IngPorcesosDeNegocio
{
    partial class FormDesplegar
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
            this.PersonasTotales = new System.Windows.Forms.Label();
            this.richTextBox1Desplegar = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // PersonasTotales
            // 
            this.PersonasTotales.AutoSize = true;
            this.PersonasTotales.Location = new System.Drawing.Point(162, 40);
            this.PersonasTotales.Name = "PersonasTotales";
            this.PersonasTotales.Size = new System.Drawing.Size(85, 13);
            this.PersonasTotales.TabIndex = 0;
            this.PersonasTotales.Text = "Personas totales";
            this.PersonasTotales.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBox1Desplegar
            // 
            this.richTextBox1Desplegar.Location = new System.Drawing.Point(94, 75);
            this.richTextBox1Desplegar.Name = "richTextBox1Desplegar";
            this.richTextBox1Desplegar.Size = new System.Drawing.Size(234, 123);
            this.richTextBox1Desplegar.TabIndex = 1;
            this.richTextBox1Desplegar.Text = "";
            this.richTextBox1Desplegar.TextChanged += new System.EventHandler(this.richTextBox1Desplegar_TextChanged);
            // 
            // FormDesplegar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 381);
            this.Controls.Add(this.richTextBox1Desplegar);
            this.Controls.Add(this.PersonasTotales);
            this.Name = "FormDesplegar";
            this.Text = "Menu Desplegar";
            this.Load += new System.EventHandler(this.FormDesplegar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PersonasTotales;
        private System.Windows.Forms.RichTextBox richTextBox1Desplegar;
    }
}