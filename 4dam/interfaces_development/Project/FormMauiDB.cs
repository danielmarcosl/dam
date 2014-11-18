using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace ADO
{
    public partial class FormMauiDB : Form
    {
        public FormMauiDB()
        {
            InitializeComponent();
        }

        // Hacer que se pueda mover el programa clickando en cualquier sitio
        private bool mouseIsDown = false;
        private Point firstPoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                // Get the difference between the two points
                int xDiff = firstPoint.X - e.Location.X;
                int yDiff = firstPoint.Y - e.Location.Y;

                // Set the new point
                int x = this.Location.X - xDiff;
                int y = this.Location.Y - yDiff;
                this.Location = new Point(x, y);
            }
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
            mouseIsDown = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }

        //

        private void cargarEmpleados()
        {
            try
            {
                // 0. Declaración de los objetos para conexión base datos con ADO
                OracleConnection conexion;
                OracleCommand comando;
                OracleDataReader reader;

                // 1. Crear la cadena de conexión a la base de datos
                conexion = new OracleConnection();
                conexion.ConnectionString =
                    "Persist Security Info=False; " +
                    "Data Source=172.18.35.50/bddam; User ID=BD_DMARCO; Password=47030791T";
                conexion.Open();

                // 2. Preparar la consulta
                comando = new OracleCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT EM#,Nombre,Edad,Domicilio FROM Empleado";

                // 3. Ejecutar la consulta
                reader = comando.ExecuteReader();

                // 4. Recoger datos de la consulta
                while (reader.Read())
                {
                    // En cada vuelta del while, se recogen los elementos
                    // de cada tupla de la consulta
                    // Según el tipo de datos de la base de datos, los datos
                    // se recogen de manera diferente
                    //      . varchar   --> GetString
                    //      . number    ..> GetDecimal
                    //      - date      --> GetDateTime
                    string claveEM, edad, nombre, domicilio;
                    //int edad;

                    // "SELECT EM#,Nombre,Edad,Domicilio FROM Empleado";
                    //          0     1     2      3
                    claveEM = reader.GetString(0);
                    nombre = reader.GetString(1);
                    //edad = (int)reader.GetDecimal(2);
                    edad = reader.GetString(2);
                    domicilio = reader.GetString(3);

                    // Crear un ListViewItem para agregar el elemento
                    ListViewItem item = new ListViewItem();

                    item.Text = claveEM;                 // Primera columna
                    item.SubItems.Add(nombre);           // Segunda columna
                    item.SubItems.Add(edad.ToString());  // Tercera columna
                    item.SubItems.Add(domicilio);        // Cuarta  columna

                    // Agregar el ítem al ListView

                    listViewEmpleado.Items.Add(item);

                }
                // 5. Cerrar conexiones
                reader.Close();
                conexion.Close();

                MessageBox.Show("Datos cargados con éxito",
                    "Aplicación de base de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cargarAutores()
        {
            try
            {
                // 0. Declaración de los objetos para conexión base datos con ADO
                OracleConnection conexion;
                OracleCommand comando;
                OracleDataReader reader;

                // 1. Crear la cadena de conexión a la base de datos
                conexion = new OracleConnection();
                conexion.ConnectionString = 
                    "Persist Security Info=False; " +
                    "Data Source=172.18.35.50/bddam; User ID=BD_DMARCO; Password=47030791T";
                conexion.Open();

                // 2. Preparar la consulta
                comando = new OracleCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT Nombre FROM Autor";

                // 3. Ejecutar la consulta
                reader = comando.ExecuteReader();

                // 4. Recoger datos de la consulta
                while (reader.Read() )
                {
                    // En cada vuelta del while, se recogen los elementos
                    // de cada tupla de la consulta
                    // Según el tipo de datos de la base de datos, los datos
                    // se recogen de manera diferente
                    //      . varchar   --> GetString
                    //      . number    ..> GetDecimal
                    //      - date      --> GetDateTime
                    string nombre;

                    // "SELECT Nombre FROM Autor";
                    nombre = reader.GetString(0); // --> Nombre : 0

                    // Copiar los datos al comboBox
                    comboBoxAutor.Items.Add(nombre);
                }
                // 5. Cerrar conexiones
                reader.Close();
                conexion.Close();

                MessageBox.Show("Datos cargados con éxito",
                    "Aplicación de base de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(OracleException ex)
            {
                // Mensaje de error si no tiene acceso a la base de datos
                MessageBox.Show(
                    "Error en conexión a base de datos: " + ex.Message,
                    "Aplicación de conexión a base de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCargarDatos_Click_1(object sender, EventArgs e)
        {
            cargarAutores();
            cargarEmpleados();
        }

        private void listViewEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewEmpleado.SelectedItems.Count != 0)
            {
                // Recogemos el item seleccionado
                ListViewItem item = listViewEmpleado.SelectedItems[0];

                textBoxApellidosUsuario.Text = item.SubItems[0].Text;         // Primera columna
                textBoxNombreEmpleado.Text = item.SubItems[1].Text;     // Segunda columna
                textBoxTurnoEmpleado.Text = item.SubItems[2].Text;       // Tercera columna
                textBoxEM.Text = item.SubItems[3].Text;  // Cuarta columna
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // 0. Declaración de los objetos para conexión base datos con ADO
                OracleConnection conexion;
                OracleCommand comando;
                OracleDataReader reader;

                // 1. Crear la cadena de conexión a la base de datos
                conexion = new OracleConnection();
                conexion.ConnectionString =
                    "Persist Security Info=False; " +
                    "Data Source=172.18.35.50/bddam; User ID=BD_DMARCO; Password=47030791T";
                conexion.Open();

                // 2. Preparar la consulta
                comando = new OracleCommand();
                comando.Connection = conexion;

                comando.CommandText = "UPDATE Empleado SET " +
                    "Nombre    = '" + textBoxNombreEmpleado.Text + "'," +
                    "Edad      = '" + textBoxTurnoEmpleado.Text + "'," +
                    "Domicilio = '" + textBoxEM.Text + "' " +
                    "WHERE EM# = '" + textBoxApellidosUsuario.Text + "'";

                // 3. Ejecutar la consulta
                comando.ExecuteNonQuery();

                // 5. Cerrar conexiones
                conexion.Close();

                listViewEmpleado.Items.Clear();

                cargarEmpleados();
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAcercaDe_Click(object sender, EventArgs e)
        {
            FormAcercaDe formAcerca;

            formAcerca = new FormAcercaDe();
            formAcerca.ShowDialog();
        }
    }
}
