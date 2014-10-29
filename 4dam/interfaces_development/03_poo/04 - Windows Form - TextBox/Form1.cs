using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplicationSegunda
{
    public partial class FormSegunda : Form
    {
        public FormSegunda()
        {
            InitializeComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            labelResultado.Visible = true;
            labelResultado.Text = "Tu nombre es " + textBoxNombre.Text + " " +
                                  textBoxApellido.Text;
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
        }
    }
}
