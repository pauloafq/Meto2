namespace IngPorcesosDeNegocio
{
    partial class Form1
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
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.richTextBoxNombre = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BottonRegreso = new System.Windows.Forms.Button();
            this.richTextBoxCedula = new System.Windows.Forms.RichTextBox();
            this.richTextBoxApellido = new System.Windows.Forms.RichTextBox();
            this.richTextBoxEdad = new System.Windows.Forms.RichTextBox();
            this.labelCedula = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(251, 328);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(75, 23);
            this.buttonIngresar.TabIndex = 0;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBoxNombre
            // 
            this.richTextBoxNombre.Location = new System.Drawing.Point(117, 117);
            this.richTextBoxNombre.Name = "richTextBoxNombre";
            this.richTextBoxNombre.Size = new System.Drawing.Size(209, 31);
            this.richTextBoxNombre.TabIndex = 1;
            this.richTextBoxNombre.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // BottonRegreso
            // 
            this.BottonRegreso.Location = new System.Drawing.Point(137, 328);
            this.BottonRegreso.Name = "BottonRegreso";
            this.BottonRegreso.Size = new System.Drawing.Size(75, 23);
            this.BottonRegreso.TabIndex = 3;
            this.BottonRegreso.Text = "Regresar";
            this.BottonRegreso.UseVisualStyleBackColor = true;
            this.BottonRegreso.Click += new System.EventHandler(this.BottonRegreso_Click);
            // 
            // richTextBoxCedula
            // 
            this.richTextBoxCedula.Location = new System.Drawing.Point(117, 52);
            this.richTextBoxCedula.Name = "richTextBoxCedula";
            this.richTextBoxCedula.Size = new System.Drawing.Size(209, 31);
            this.richTextBoxCedula.TabIndex = 4;
            this.richTextBoxCedula.Text = "";
            this.richTextBoxCedula.TextChanged += new System.EventHandler(this.richTextBoxCedula_TextChanged);
            // 
            // richTextBoxApellido
            // 
            this.richTextBoxApellido.Location = new System.Drawing.Point(117, 185);
            this.richTextBoxApellido.Name = "richTextBoxApellido";
            this.richTextBoxApellido.Size = new System.Drawing.Size(209, 31);
            this.richTextBoxApellido.TabIndex = 5;
            this.richTextBoxApellido.Text = "";
            this.richTextBoxApellido.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // richTextBoxEdad
            // 
            this.richTextBoxEdad.Location = new System.Drawing.Point(117, 244);
            this.richTextBoxEdad.Name = "richTextBoxEdad";
            this.richTextBoxEdad.Size = new System.Drawing.Size(209, 31);
            this.richTextBoxEdad.TabIndex = 6;
            this.richTextBoxEdad.Text = "";
            // 
            // labelCedula
            // 
            this.labelCedula.AutoSize = true;
            this.labelCedula.Location = new System.Drawing.Point(55, 52);
            this.labelCedula.Name = "labelCedula";
            this.labelCedula.Size = new System.Drawing.Size(40, 13);
            this.labelCedula.TabIndex = 7;
            this.labelCedula.Text = "Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(51, 247);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(32, 13);
            this.labelEdad.TabIndex = 9;
            this.labelEdad.Text = "Edad";
            this.labelEdad.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(55, 185);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 10;
            this.labelApellido.Text = "Apellido";
            this.labelApellido.UseMnemonic = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 401);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCedula);
            this.Controls.Add(this.richTextBoxEdad);
            this.Controls.Add(this.richTextBoxApellido);
            this.Controls.Add(this.richTextBoxCedula);
            this.Controls.Add(this.BottonRegreso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxNombre);
            this.Controls.Add(this.buttonIngresar);
            this.Name = "Form1";
            this.Text = "Ingresar Persona";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.RichTextBox richTextBoxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BottonRegreso;
        private System.Windows.Forms.RichTextBox richTextBoxCedula;
        private System.Windows.Forms.RichTextBox richTextBoxApellido;
        private System.Windows.Forms.RichTextBox richTextBoxEdad;
        private System.Windows.Forms.Label labelCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelApellido;
    }
}

