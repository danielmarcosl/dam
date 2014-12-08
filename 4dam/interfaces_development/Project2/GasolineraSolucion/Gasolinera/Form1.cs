using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gasolinera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Botón Calcular1
        private void buttonCalcular1_Click(object sender, EventArgs e)
        {
            // Creamos las variables para Litros, Euros y Euros/Litro
            float euroLitro, litro, euro;

            // Pasamos el contenido del TextBox de Litros a la variable litro
            litro = float.Parse(textBoxLitros1.Text);
            // Pasamos el contenido del TextBox de Euros/Litro a la variable euroLitro
            euroLitro = float.Parse(textBoxEurosLitro.Text);
            // Calculamos el producto de ambas variables para obtener el precio de los litros
            euro = (litro * euroLitro);

            // Pasamos el resultado al TextBox de Euros
            textBoxEuros1.Text = euro.ToString();
        }

        // Botón Cobrar1
        private void buttonCobrar1_Click(object sender, EventArgs e)
        {
            // Cremos las variables para Euros y Surtidor
            float euro, surtidor;

            // Pasamos el contenido del TextBox de Euros a la variable euro
            euro = float.Parse(textBoxEuros1.Text);
            // Pasamos el contenido del TextBox de Surtidor a la variable surtidor
            surtidor = float.Parse(textBoxSurtidor1.Text);
            // Calculamos la suma de ambas variables
            surtidor = surtidor + euro;

            // Pasamos el resultado al TextBox de SurTidor
            textBoxSurtidor1.Text = surtidor.ToString();

            // Vaciamos los TextBox de Litros y Euros
            textBoxLitros1.Text = "";
            textBoxEuros1.Text = "";
        }

        // Botón Vaciar1
        private void buttonVaciar1_Click(object sender, EventArgs e)
        {
            // Vaciamos el TextBox de Litros
            textBoxLitros1.Text = "";
            // Vaciamos el TextBox de Euros
            textBoxEuros1.Text = "";
            // Ponemos el TextBox de Sutirdor a 0
            textBoxSurtidor1.Text = "0";
        }

        // Botón Calcular2
        private void buttonCalcular2_Click(object sender, EventArgs e)
        {
            // Creamos las variables para Litros, Euros y Euros/Litro
            float euroLitro, litro, euro;

            // Pasamos el contenido del TextBox de Litros a la variable litro
            litro = float.Parse(textBoxLitros2.Text);
            // Pasamos el contenido del TextBox de Euros/Litro a la variable euroLitro
            euroLitro = float.Parse(textBoxEurosLitro.Text);
            // Calculamos el producto de ambas variables para obtener el precio de los litros
            euro = (litro * euroLitro);

            // Pasamos el resultado al TextBox de Euros
            textBoxEuros2.Text = euro.ToString();
        }

        // Botón Cobrar
        private void buttonCobrar2_Click(object sender, EventArgs e)
        {
            // Cremos las variables para Euros y Surtidor
            float euro, surtidor;

            // Pasamos el contenido del TextBox de Euros a la variable euro
            euro = float.Parse(textBoxEuros2.Text);
            // Pasamos el contenido del TextBox de Surtidor a la variable surtidor
            surtidor = float.Parse(textBoxSurtidor2.Text);
            // Calculamos la suma de ambas variables
            surtidor = surtidor + euro;

            // Pasamos el resultado al TextBox de SurTidor
            textBoxSurtidor2.Text = surtidor.ToString();

            // Vaciamos los TextBox de Litros y Euros
            textBoxLitros2.Text = "";
            textBoxEuros2.Text = "";
        }

        // Botón Vaciar2
        private void buttonVaciar2_Click(object sender, EventArgs e)
        {
            // Vaciamos el TextBox de Litros
            textBoxLitros2.Text = "";
            // Vaciamos el TextBox de Euros
            textBoxEuros2.Text = "";
            // Ponemos el TextBox de Sutirdor a 0
            textBoxSurtidor2.Text = "0";
        }

        // Botón Calcular3
        private void buttonCalcular3_Click(object sender, EventArgs e)
        {
            // Creamos las variables para Litros, Euros y Euros/Litro
            float euroLitro, litro, euro;

            // Pasamos el contenido del TextBox de Litros a la variable litro
            litro = float.Parse(textBoxLitros3.Text);
            // Pasamos el contenido del TextBox de Euros/Litro a la variable euroLitro
            euroLitro = float.Parse(textBoxEurosLitro.Text);
            // Calculamos el producto de ambas variables para obtener el precio de los litros
            euro = (litro * euroLitro);

            // Pasamos el resultado al TextBox de Euros
            textBoxEuros3.Text = euro.ToString();
        }

        // Botón Cobrar3
        private void buttonCobrar3_Click(object sender, EventArgs e)
        {
            // Cremos las variables para Euros y Surtidor
            float euro, surtidor;

            // Pasamos el contenido del TextBox de Euros a la variable euro
            euro = float.Parse(textBoxEuros3.Text);
            // Pasamos el contenido del TextBox de Surtidor a la variable surtidor
            surtidor = float.Parse(textBoxSurtidor3.Text);
            // Calculamos la suma de ambas variables
            surtidor = surtidor + euro;

            // Pasamos el resultado al TextBox de SurTidor
            textBoxSurtidor3.Text = surtidor.ToString();

            // Vaciamos los TextBox de Litros y Euros
            textBoxLitros3.Text = "";
            textBoxEuros3.Text = "";
        }

        // Botón Vaciar
        private void buttonVaciar3_Click(object sender, EventArgs e)
        {
            // Vaciamos el TextBox de Litros
            textBoxLitros3.Text = "";
            // Vaciamos el TextBox de Euros
            textBoxEuros3.Text = "";
            // Ponemos el TextBox de Sutirdor a 0
            textBoxSurtidor3.Text = "0";
        }
    }
}
