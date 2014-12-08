using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace TestForm1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            cargarnombre();
        }

        private void cargarnombre()
        {
            OracleConnection conexion;
            OracleCommand comando;
            OracleDataReader reader;

            conexion = new OracleConnection();
            conexion.ConnectionString =
                    "Persist Security Info=False; " +
                    "localhost; User ID=prueba; Password=prueba";
            conexion.Open();

            comando = new OracleCommand();
            comando.Connection = conexion;
            comando.CommandText = "SELECT NOMBRE FROM AUTOR";

            reader = comando.ExecuteReader();
            
            comboBoxNombres.Items.Clear();
            while (reader.Read())
            {
                string nombre;

                nombre = reader.GetString(0);

                comboBoxNombres.Items.Add(nombre);
            }
            reader.Close();
            conexion.Close();
        }

        private void cargarlibros()
        {
            OracleConnection conexion;
            OracleCommand comando;
            OracleDataReader reader;

            conexion = new OracleConnection();
            conexion.ConnectionString =
                "Persist Security Info=False; " +
                "localhost; User ID=prueba; password=prueba";
            conexion.Open();

            comando = new OracleCommand();
            comando.Connection = conexion;
            comando.CommandText = " SELECT LIBRO.NOMBRE " +
                "FROM LIBROS,AUTOR" +
                "WHERE AUTOR.AU# = LIBROS.AU# AND" +
                "AUTOR = " + comboBoxNombres.SelectedItem.ToString();

            reader = comando.ExecuteReader();

            comboBoxLibro.Items.Clear();
            while (reader.Read())
            {
                string nombre;

                nombre = reader.GetString(0);

                comboBoxLibro.Items.Add(nombre);
            }
            reader.Close();
            conexion.Close();
        }


        
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            cargarlibros();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (comboBoxLibro.SelectedItem.Count != 0)
            EditarLibro formeditar = new EditarLibro;




            DialogResult resultado = 
            if (
        }
    }
}
