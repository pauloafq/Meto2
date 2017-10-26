using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IngPorcesosDeNegocio
{
    class Persona
    {
        private int cedula;
        private string nombre;
        private string apellido;
        private int edad; 


        public Persona()
        {
            cedula = 0;
            nombre = "";
            apellido = "";
            edad = 0;
        }

        public Persona(int _cedula, string _nombre,
                        string _apellido, int _edad)
        {
            cedula = _cedula;
            nombre = _nombre;
            apellido = _apellido;
            edad = _edad;
        }

        public void MostrarAlgo()
        {
            //System.ou
            MessageBox.Show("desde persona");

        }
        //sets *************************************
        public void SetCedula(int _cedula)
        {
            this.cedula = _cedula;

        }

        public void SetNombre(string _nombre)
        {
            this.nombre = _nombre;

        }

        public void SetApellido(string _apellido)
        {
            this.apellido = _apellido;

        }

        public void SetEdad(int _edad)
        {
            this.edad = _edad;

        }

        //gets ************************************

        public int GetCedula()
        {
            return this.cedula;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public string GetApellido()
        {
            return this.apellido;
        }

        public int GetEdad()
        {
            return this.edad;
        }
    }

    
}

