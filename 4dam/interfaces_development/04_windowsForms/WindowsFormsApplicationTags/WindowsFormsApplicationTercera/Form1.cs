using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplicationTercera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //private void buttonPrimero_Click(object sender, EventArgs e)
        //{
        //    labelTexto.Text = "Boton pulsado B1";
        //}
        //private void buttonSegundo_Click(object sender, EventArgs e)
        //{
        //    labelTexto.Text = "Boton pulsado B2";
        //}
        //private void buttonTercero_Click(object sender, EventArgs e)
        //{
        //    labelTexto.Text = "Boton pulsado B3";
        //}
        //private void buttonCuarto_Click(object sender, EventArgs e)
        //{
        //    labelTexto.Text = "Boton pulsado B4";
        //}
        //private void buttonQuinto_Click(object sender, EventArgs e)
        //{
        //    labelTexto.Text = "Boton pulsado B5";
        //}
        private void button_Generica(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            string valor = sender.ToString();

            labelTexto.Text = "Boton pulsado " + boton.Tag.ToString();
        }
    }
}
