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
        public FormPersonas()
        {
            InitializeComponent();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            Persona p1 = new Persona(textBoxNombre.Text,
                Int32.Parse(textBoxNacimiento.Text),
                textBoxdireccion.Text);

            labelResultado1.Text = p1.NombreCompleto();
        }

        private void buttonModificar_Click(object sender, EventArgs e, Persona p1)
        {
            
        }
    }
}