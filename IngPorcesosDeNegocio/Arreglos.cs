using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace IngPorcesosDeNegocio
{

    class Arreglos
    {
        ArrayList personas = new ArrayList();


        public void AgregarPersona(int _cedula, string _nombre,
                                    string _apellido, int _edad)
        {
            // nota verificar que la cedula no exista
            personas.Add(new Persona(_cedula, _nombre, _apellido, _edad)); // agrega personas al arrey 

        }

        public void DesplegarPersonas() // este metodo solo es para llamar al otro con el mismo nombre
        {
            this.DesplegarPersonas(personas, "\t");

        }
                        
        // IEnumerable
        public void DesplegarPersonas(IEnumerable _lista , string _separador)
        {
            foreach (Object obj in _lista);

            string salida;
            for(int i=0; i<personas.Count; i++)
            {
                Persona per = (Persona)personas[i];
                salida = per.GetNombre() + "\t";
                salida += per.GetCedula().ToString() + "\t";
                salida += per.GetApellido() + "\t";
                salida += per.GetEdad().ToString() + "\t ";
                MessageBox.Show(salida);
            }
            
            

            //MessageBox.Show(_lista.)
            //MessageBox.Show("{0}{1}", _separador);
            //salida = Persona.
            //int cedula = Int32.Parse(richTextBoxCedula.Text);
            MessageBox.Show(personas.ToString());
            //foreach (Object obj in _lista);

            //MessageBox.Show("");

            //personas. 

        }

        //public static void PrintValues(IEnumerable myList)
        //{
        //    foreach (Object obj in myList)
        //    Console.Write("   {0}", obj);
        //    Console.WriteLine();
        //}


    }


}
