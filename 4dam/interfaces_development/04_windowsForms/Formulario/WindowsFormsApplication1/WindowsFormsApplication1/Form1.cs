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

        private void labelResultado_Click(object sender, EventArgs e)
        {
            Console.WriteLine(textBoxNombre.Text + " " + textBoxApellidos.Text);
            
            if (checkBoxEstudia.Checked)
            {
                Console.WriteLine("Estudios: " + comboBoxTipo.Text);
            }
            else
            {
                Console.WriteLine("No posee estudios");
            }

            if (checkBoxCarnet.Checked)
            {
                Console.WriteLine("Posee carnet de conducir");
            }
            if (checkBoxCarnet.Checked)
            {
            }

        }
    }
}
