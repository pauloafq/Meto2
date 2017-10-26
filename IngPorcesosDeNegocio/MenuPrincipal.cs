using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngPorcesosDeNegocio
{

    public partial class MenuPrincipal : Form
    {
        FormDesplegar fd = new FormDesplegar();
        Arreglos arreglos = new Arreglos();
        //Form1 form1 = new Form1(); 
        //RichTextBox1des 1
        
        public MenuPrincipal()
        {
            InitializeComponent();

        }

        private void button3Desplegar_Click(object sender, EventArgs e)
        {
            fd.Show();// nuestra los datos en este
            //fd.Show(richTextBox1Desplegar.arreglos.DesplegarPersonas());
            //arreglos.DesplegarPersonas();
            arreglos.DesplegarPersonas();
            //RichTextBox.text

            
            // llamar al form de desplegar 
        }

        private void button1Ingresar_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            //richtextbox1.text =

            //Application.Run(new Form1());
            //Form1.Show();
        }
    }
}
