namespace IngPorcesosDeNegocio
{
    partial class MenuPrincipal
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
            this.button1Ingresar = new System.Windows.Forms.Button();
            this.button2Borrar = new System.Windows.Forms.Button();
            this.button3Desplegar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4Salir = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1Ingresar
            // 
            this.button1Ingresar.Location = new System.Drawing.Point(64, 236);
            this.button1Ingresar.Name = "button1Ingresar";
            this.button1Ingresar.Size = new System.Drawing.Size(75, 23);
            this.button1Ingresar.TabIndex = 0;
            this.button1Ingresar.Text = "Ingresar";
            this.button1Ingresar.UseVisualStyleBackColor = true;
            this.button1Ingresar.Click += new System.EventHandler(this.button1Ingresar_Click);
            // 
            // button2Borrar
            // 
            this.button2Borrar.Location = new System.Drawing.Point(185, 236);
            this.button2Borrar.Name = "button2Borrar";
            this.button2Borrar.Size = new System.Drawing.Size(75, 23);
            this.button2Borrar.TabIndex = 1;
            this.button2Borrar.Text = "Borrar";
            this.button2Borrar.UseVisualStyleBackColor = true;
            // 
            // button3Desplegar
            // 
            this.button3Desplegar.Location = new System.Drawing.Point(311, 236);
            this.button3Desplegar.Name = "button3Desplegar";
            this.button3Desplegar.Size = new System.Drawing.Size(75, 23);
            this.button3Desplegar.TabIndex = 2;
            this.button3Desplegar.Text = "Desplegar Personas";
            this.button3Desplegar.UseVisualStyleBackColor = true;
            this.button3Desplegar.Click += new System.EventHandler(this.button3Desplegar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione una opcion de acuerdo al boton ";
            // 
            // button4Salir
            // 
            this.button4Salir.Location = new System.Drawing.Point(185, 291);
            this.button4Salir.Name = "button4Salir";
            this.button4Salir.Size = new System.Drawing.Size(75, 23);
            this.button4Salir.TabIndex = 4;
            this.button4Salir.Text = "Salir";
            this.button4Salir.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(375, 78);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 385);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button4Salir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3Desplegar);
            this.Controls.Add(this.button2Borrar);
            this.Controls.Add(this.button1Ingresar);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Ingresar;
        private System.Windows.Forms.Button button2Borrar;
        private System.Windows.Forms.Button button3Desplegar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4Salir;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}