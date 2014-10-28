using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            labelResultado.Text = "Tu nombre es " + textBoxNombre.Text + " " + textBoxApellidos.Text;

            textBoxNombre.Text = "";
            textBoxApellidos.Text = "";
        }

    }
}
