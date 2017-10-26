using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace IngPorcesosDeNegocio
{
    public partial class Form1 : Form
    {
        //string nombre;
        //int edad;
        Persona p = new Persona(); // se instancia persona 
        MenuPrincipal principal = new MenuPrincipal(); // se instancia princiapl para poder llamarlo 
        //ArrayList personas = new ArrayList(); // aqui se guardaran todas las personas ingresadas
        Arreglos personas = new Arreglos();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           /// richTextBox1.Text = "hello world";
           //me
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cedula = Int32.Parse(richTextBoxCedula.Text);
            string nombre = richTextBoxNombre.Text;
            string apellido = richTextBoxApellido.Text;
            int edad = Int32.Parse(richTextBoxEdad.Text);
            personas.AgregarPersona(cedula, nombre, apellido, edad);    
            MessageBox.Show("Los datos se han ingresado correctamente");
        }

        private void BottonRegreso_Click(object sender, EventArgs e)
        {
            
            principal.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBoxCedula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
