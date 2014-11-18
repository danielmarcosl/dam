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


        // EMPLEADOS
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
                comando.CommandText = "SELECT EM#,NombreEmpleado,ApellidosEmpleado,Turno FROM Empleado";

                // 3. Ejecutar la consulta
                reader = comando.ExecuteReader();

                // 4. Recoger datos de la consulta
                listViewEmpleado.Items.Clear();
                while (reader.Read())
                {
                    // En cada vuelta del while, se recogen los elementos
                    // de cada tupla de la consulta
                    // Según el tipo de datos de la base de datos, los datos
                    // se recogen de manera diferente
                    //      . varchar   --> GetString
                    //      . number    ..> GetDecimal
                    //      - date      --> GetDateTime
                    string claveEM, nombreEmpleado, apellidosEmpleado, turno;
                    //int edad;

                    // "SELECT EM#,NombreEmpleado,ApellidosUsuario,Turno FROM Empleado";
                    //          0        1               2           3
                    // reader.GetDateTime(#).ToShortDateString()
                    claveEM = reader.GetString(0);
                    nombreEmpleado = reader.GetString(1);
                    //edad = (int)reader.GetDecimal(2);
                    apellidosEmpleado = reader.GetString(2);
                    turno = reader.GetString(3);

                    // Crear un ListViewItem para agregar el elemento
                    ListViewItem item = new ListViewItem();

                    item.Text = claveEM;                      // Primera columna
                    item.SubItems.Add(nombreEmpleado);        // Segunda columna
                    item.SubItems.Add(apellidosEmpleado);     // Tercera columna
                    item.SubItems.Add(turno);                 // Cuarta  columna

                    // Agregar el ítem al ListView

                    listViewEmpleado.Items.Add(item);

                }
                // 5. Cerrar conexiones
                reader.Close();
                conexion.Close();

                MessageBox.Show("Empleados cargados con éxito",
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
        // USUARIOS
        private void cargarUsuarios()
        {
            try
            {
                OracleConnection conexion;
                OracleCommand comando;
                OracleDataReader reader;

                conexion = new OracleConnection();
                conexion.ConnectionString = 
                    "Persist Security Info=False; " +
                    "Data Source=172.18.35.50/bddam; User ID=BD_DMARCO; Password=47030791T";
                conexion.Open();

                comando = new OracleCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT US#,NombreUsuario,ApellidosUsuario,DireccionUsuario FROM Usuario";

                reader = comando.ExecuteReader();


                listViewUsuario.Items.Clear();
                while (reader.Read() )
                {
                    string claveUS, nombreUsuario, apellidosUsuario, direccionUsuario;

                    claveUS = reader.GetString(0);
                    nombreUsuario = reader.GetString(1);
                    apellidosUsuario = reader.GetString(2);
                    direccionUsuario = reader.GetString(3);

                    ListViewItem item = new ListViewItem();

                    item.Text = claveUS;                      // Primera columna
                    item.SubItems.Add(nombreUsuario);         // Segunda columna
                    item.SubItems.Add(apellidosUsuario);      // Tercera columna
                    item.SubItems.Add(direccionUsuario);      // Cuarta  columna

                    listViewUsuario.Items.Add(item);
                }
                reader.Close();
                conexion.Close();

                MessageBox.Show("Usuarios cargados con éxito",
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

        //-----------------CATEGORIA
        private void cargarCategorias()
        {
            try
            {
                OracleConnection conexion;
                OracleCommand comando;
                OracleDataReader reader;

                conexion = new OracleConnection();
                conexion.ConnectionString =
                    "Persist Security Info=False; " +
                    "Data Source=172.18.35.50/bddam; User ID=BD_DMARCO; Password=47030791T";
                conexion.Open();

                comando = new OracleCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT Libro.LI#, Libro.NombreLibro, Libro.Fecha, Categoria.NombreCategoria, Autor.NombreAutor, " + 
                    "Editorial.NombreEditorial FROM Libro, Categoria, Autor, Editorial WHERE Libro.CA#=Categoria.CA# AND Libro.ED#=Editorial.ED# " + 
                    "AND Libro.AU#=Autor.AU# ORDER BY LI#";

                reader = comando.ExecuteReader();


                listViewCategoriaLibro.Items.Clear();
                while (reader.Read())
                {
                    string claveLI, nombreLibro, fecha, nombreCategoria, nombreAutor, nombreEditorial;

                    // SELECT Libro.LI#, Libro.NombreLibro, Libro.Fecha, Categoria.NombreCategoria, Autor.NombreAutor, Editorial.NombreEditorial
                    //            0              1               2                  3                      4                      5
                    claveLI = reader.GetString(0);
                    nombreLibro = reader.GetString(1);
                    fecha = reader.GetDateTime(2).ToShortDateString();
                    nombreCategoria = reader.GetString(3);
                    nombreAutor = reader.GetString(4);
                    nombreEditorial = reader.GetString(5);

                    ListViewItem item = new ListViewItem();

                    item.Text = claveLI;                 // Primera columna
                    item.SubItems.Add(nombreLibro);      // Segunda columna
                    item.SubItems.Add(fecha);            // Tercera columna
                    item.SubItems.Add(nombreCategoria);  // Cuarta  columna
                    item.SubItems.Add(nombreAutor);      // Quinta  columna
                    item.SubItems.Add(nombreEditorial);  // Sexta   columna

                    listViewCategoriaLibro.Items.Add(item);
                }
                reader.Close();
                conexion.Close();

                MessageBox.Show("Libros cargados con éxito",
                    "Aplicación de base de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OracleException ex)
            {
                MessageBox.Show(
                    "Error en conexión a base de datos: " + ex.Message,
                    "Aplicación de conexión a base de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try // Count Categoria
            {
                OracleConnection conexion;
                OracleCommand comando;
                OracleDataReader reader;

                conexion = new OracleConnection();
                conexion.ConnectionString =
                    "Persist Security Info=False; " +
                    "Data Source=172.18.35.50/bddam; User ID=BD_DMARCO; Password=47030791T";
                conexion.Open();

                comando = new OracleCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT Categoria.NombreCategoria, COUNT(*) FROM Libro, Categoria WHERE Libro.CA#=Categoria.CA# GROUP BY Categoria.NombreCategoria";

                reader = comando.ExecuteReader();


                listViewCategoria.Items.Clear();
                while (reader.Read())
                {
                    string nombreCategoria;
                    int claveCA;

                    nombreCategoria = reader.GetString(0);
                    claveCA = (int)reader.GetDecimal(1);

                    ListViewItem item = new ListViewItem();

                    item.Text = nombreCategoria;  // Primera columna
                    item.SubItems.Add(claveCA.ToString());   // Segunda columna

                    listViewCategoria.Items.Add(item);
                }
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
        }//-----------------CATEGORIA

        // Hasta aqui


        private void listViewCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCategoria.SelectedItems.Count != 0)
            {
                listViewCategoria.Items.Clear();
                ListViewItem item = listViewCategoria.SelectedItems[0];

                
            }
        }


        private void buttonCargarDatos_Click_1(object sender, EventArgs e)
        {
            cargarUsuarios();
            cargarEmpleados();
            cargarCategorias();
        }

        private void listViewEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewEmpleado.SelectedItems.Count != 0)
            {
                // Recogemos el item seleccionado
                ListViewItem item = listViewEmpleado.SelectedItems[0];

                textBoxApellidosEmpleado.Text = item.SubItems[0].Text;   // Primera columna
                textBoxNombreEmpleado.Text = item.SubItems[1].Text;     // Segunda columna
                textBoxTurnoEmpleado.Text = item.SubItems[2].Text;      // Tercera columna
                textBoxEM.Text = item.SubItems[3].Text;                 // Cuarta columna
            }
        }

        private void buttonActualizarEmpleado_Click(object sender, EventArgs e)
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
                    "EM#='"+ textBoxEM.Text + "'," +
                    "NombreEmpleado='" + textBoxNombreEmpleado.Text + "'," +
                    "ApellidosEmpleado='" + textBoxApellidosEmpleado.Text + "'," +
                    "Turno='" + textBoxTurnoEmpleado.Text + "'" +
                    "WHERE EM#='" + textBoxTurnoEmpleado.Text + "'";

                // 3. Ejecutar la consulta
                comando.ExecuteNonQuery();

                // 5. Cerrar conexiones
                conexion.Close();

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
