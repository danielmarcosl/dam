using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace ADO_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCargarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                // Declaración de los objetos
                OracleConnection conexion;
                OracleCommand comando;
                OracleDataReader reader;

                // Conexión a la DB
                conexion = new OracleConnection();
                conexion.ConnectionString =
                    "Persist Security Info=False; " +
                    "Data Source=172.18.35.50/bddam; User ID=BD_DMARCO; Password=47030791T";
                conexion.Open();

                // Preparar consulta
                comando = new OracleCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT name_tables FROM user_tables";

                // Ejecutar la consulta
                reader = comando.ExecuteReader();

                // Obtener datos de la consulta
                while (reader.Read())
                {
                    string name_table;

                    name_table = reader.GetString(0);

                    comboBoxSeleccionarTabla.Items.Add(name_table);
                }

                // Cerrar conexiones
                reader.Close();
                conexion.Close();
            }
            catch (OracleException ex)
            {
                // Mensaje de error si no tiene acceso a la base de datos
                MessageBox.Show(
                    "Error en conexión a base de datos: " + ex.Message,
                    "Aplicación de conexión a base de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
