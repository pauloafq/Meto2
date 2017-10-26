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
    public partial class FormDesplegar : Form
    {
        public FormDesplegar()
        {
            InitializeComponent();
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormDesplegar_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1Desplegar_TextChanged(object sender, EventArgs e)
        {
            this.Text = "prueba";
            //richTextBox1Desplegar.Show();
        }
    }
}
