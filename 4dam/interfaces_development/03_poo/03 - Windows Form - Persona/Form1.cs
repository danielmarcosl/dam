using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplicationPrimera
{
    public partial class FormPersonas : Form
    {
        // Atributos
        Persona p1;
        
        public FormPersonas()
        {
            InitializeComponent();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            //p1 = new Persona(
            //    textBoxNombre.Text,
            //    Int32.Parse(textBoxAnioNac.Text),
            //    textBoxDireccion.Text);
            //labelResultado.Text = p1.NombreCompleto(); 
            Persona nueva = new Persona(
                  textBoxNombre.Text,
                  Int32.Parse(textBoxAnioNac.Text),
                  textBoxDireccion.Text);

            listViewResultado.Items.Add(nueva.NombreCompleto());
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            p1.ModificarNombre(textBoxNombre.Text);
            p1.ModificarAnio(Int32.Parse(textBoxAnioNac.Text));
            p1.ModificarDireccion(textBoxDireccion.Text);

            // labelResultado.Text = p1.NombreCompleto(); 
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            listViewResultado.Items.Clear();
        }


    }
}
