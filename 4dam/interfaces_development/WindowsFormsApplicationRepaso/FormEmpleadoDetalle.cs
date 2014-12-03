using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplicationRepaso
{
    public partial class FormEmpleadoDetalle : Form
    {
        public FormEmpleadoDetalle()
        {
            InitializeComponent();
        }

        public string EM
        {  
            set
            { 
                textBoxEM.Text = value; 
            } 
        }
        
        public void FijarEM(string em)
        {
            textBoxEM.Text = em;
        }

        public void FijarNombre(string nom)
        {
            textBoxNombre.Text = nom;
        }

        public void FijarEdad(string edad)
        {
            textBoxEdad.Text = edad;
        }

        public void FijarDomicilio(string domicilio)
        {
            textBoxDomicilio.Text = domicilio;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
