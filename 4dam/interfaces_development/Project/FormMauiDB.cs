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
            }
            catch (OracleException ex)
            {
                // Mensaje de error si no tiene acceso a la base de datos
                MessageBox.Show(
                    "Error al cargar Empleados: " + ex.Message,
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
            }
            catch(OracleException ex)
            {
                // Mensaje de error si no tiene acceso a la base de datos
                MessageBox.Show(
                    "Error al cargar Usuarios: " + ex.Message,
                    "Aplicación de conexión a base de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // CATEGORIAS
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
            }
            catch (OracleException ex)
            {
                MessageBox.Show(
                    "Error al cargar Categorias: " + ex.Message,
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
                    "Error al cargar el contador de Categorias: " + ex.Message,
                    "Aplicación de conexión a base de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }// CATEGORIA


        // ESTILO
        private void cargarEstilos()
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
                comando.CommandText = "SELECT Libro.LI#, Libro.NombreLibro, Libro.Fecha, Estilo.NombreEstilo, Autor.NombreAutor, Editorial.NombreEditorial " +
                    "FROM Libro, Estilo, Autor, Editorial WHERE Libro.ES#=Estilo.ES# AND Libro.ED#=Editorial.ED# AND Libro.AU#=Autor.AU# ORDER BY LI#";

                reader = comando.ExecuteReader();

                listViewEstiloLibro.Items.Clear();
                while (reader.Read())
                {
                    string claveLI, nombreLibro, fecha, nombreEstilo, nombreAutor, nombreEditorial;

                    // SELECT Libro.LI#, Libro.NombreLibro, Libro.Fecha, Categoria.NombreCategoria, Autor.NombreAutor, Editorial.NombreEditorial
                    //            0              1               2                  3                      4                      5
                    claveLI = reader.GetString(0);
                    nombreLibro = reader.GetString(1);
                    fecha = reader.GetDateTime(2).ToShortDateString();
                    nombreEstilo = reader.GetString(3);
                    nombreAutor = reader.GetString(4);
                    nombreEditorial = reader.GetString(5);

                    ListViewItem item = new ListViewItem();

                    item.Text = claveLI;                 // Primera columna
                    item.SubItems.Add(nombreLibro);      // Segunda columna
                    item.SubItems.Add(fecha);            // Tercera columna
                    item.SubItems.Add(nombreEstilo);  // Cuarta  columna
                    item.SubItems.Add(nombreAutor);      // Quinta  columna
                    item.SubItems.Add(nombreEditorial);  // Sexta   columna

                    listViewEstiloLibro.Items.Add(item);
                }
                reader.Close();
                conexion.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(
                    "Error al cargar Estilos: " + ex.Message,
                    "Aplicación de conexión a base de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try // Count Estilo
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
                comando.CommandText = "SELECT Estilo.NombreEstilo, COUNT(*) FROM Libro, Estilo WHERE Libro.ES#=Estilo.ES# GROUP BY Estilo.NombreEstilo";

                reader = comando.ExecuteReader();

                listViewEstilo.Items.Clear();
                while (reader.Read())
                {
                    string nombreEstilo;
                    int claveES;

                    nombreEstilo = reader.GetString(0);
                    claveES = (int)reader.GetDecimal(1);

                    ListViewItem item = new ListViewItem();

                    item.Text = nombreEstilo;  // Primera columna
                    item.SubItems.Add(claveES.ToString());   // Segunda columna

                    listViewEstilo.Items.Add(item);
                }
                reader.Close();
                conexion.Close();
            }
            catch (OracleException ex)
            {
                // Mensaje de error si no tiene acceso a la base de datos
                MessageBox.Show(
                    "Error al cargar el contador de Estilos: " + ex.Message,
                    "Aplicación de conexión a base de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }// ESTILO

        // AUTORES
        private void cargarAutores()
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
                comando.CommandText = "SELECT Libro.LI#, Libro.NombreLibro, Libro.Fecha, Autor.AU#, Editorial.NombreEditorial FROM Libro, Autor, " +
                    "Editorial WHERE Libro.ED#=Editorial.ED# AND Libro.AU#=Autor.AU# ORDER BY LI#";

                reader = comando.ExecuteReader();

                listViewAutoresLibro.Items.Clear();
                while (reader.Read())
                {
                    string claveLI, nombreLibro, fecha, nombreAutor, nombreEditorial;

                    claveLI = reader.GetString(0);
                    nombreLibro = reader.GetString(1);
                    fecha = reader.GetDateTime(2).ToShortDateString();
                    nombreAutor = reader.GetString(3);
                    nombreEditorial = reader.GetString(4);

                    ListViewItem item = new ListViewItem();

                    item.Text = claveLI;                 // Primera columna
                    item.SubItems.Add(nombreLibro);      // Segunda columna
                    item.SubItems.Add(fecha);            // Tercera columna
                    item.SubItems.Add(nombreAutor);      // Cuarta  columna
                    item.SubItems.Add(nombreEditorial);  // Quinta  columna

                    listViewAutoresLibro.Items.Add(item);
                }
                reader.Close();
                conexion.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(
                    "Error al cargar Autores: " + ex.Message,
                    "Aplicación de conexión a base de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try // Count Estilo
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
                comando.CommandText = "SELECT Estilo.NombreEstilo, COUNT(*) FROM Libro, Estilo WHERE Libro.ES#=Estilo.ES# GROUP BY Estilo.NombreEstilo";

                reader = comando.ExecuteReader();

                listViewEstilo.Items.Clear();
                while (reader.Read())
                {
                    string nombreEstilo;
                    int claveES;

                    nombreEstilo = reader.GetString(0);
                    claveES = (int)reader.GetDecimal(1);

                    ListViewItem item = new ListViewItem();

                    item.Text = nombreEstilo;  // Primera columna
                    item.SubItems.Add(claveES.ToString());   // Segunda columna

                    listViewEstilo.Items.Add(item);
                }
                reader.Close();
                conexion.Close();
            }
            catch (OracleException ex)
            {
                // Mensaje de error si no tiene acceso a la base de datos
                MessageBox.Show(
                    "Error al cargar el contador de Estilos: " + ex.Message,
                    "Aplicación de conexión a base de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }// AUTORES


        // AUTORES
        private void cargarPrestamos()
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
                comando.CommandText = "SELECT Libro.LI#, Libro.NombreLibro, Libro.Fecha, Autor.AU#, Editorial.NombreEditorial FROM Libro, Autor, " +
                    "Editorial WHERE Libro.ED#=Editorial.ED# AND Libro.AU#=Autor.AU# ORDER BY LI#";

                reader = comando.ExecuteReader();

                listViewAutoresLibro.Items.Clear();
                while (reader.Read())
                {
                    string claveLI, nombreLibro, fecha, nombreAutor, nombreEditorial;

                    claveLI = reader.GetString(0);
                    nombreLibro = reader.GetString(1);
                    fecha = reader.GetDateTime(2).ToShortDateString();
                    nombreAutor = reader.GetString(3);
                    nombreEditorial = reader.GetString(4);

                    ListViewItem item = new ListViewItem();

                    item.Text = claveLI;                 // Primera columna
                    item.SubItems.Add(nombreLibro);      // Segunda columna
                    item.SubItems.Add(fecha);            // Tercera columna
                    item.SubItems.Add(nombreAutor);      // Cuarta  columna
                    item.SubItems.Add(nombreEditorial);  // Quinta  columna

                    listViewAutoresLibro.Items.Add(item);
                }
                reader.Close();
                conexion.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(
                    "Error al cargar Autores: " + ex.Message,
                    "Aplicación de conexión a base de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try // Count Estilo
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
                comando.CommandText = "SELECT Estilo.NombreEstilo, COUNT(*) FROM Libro, Estilo WHERE Libro.ES#=Estilo.ES# GROUP BY Estilo.NombreEstilo";

                reader = comando.ExecuteReader();

                listViewEstilo.Items.Clear();
                while (reader.Read())
                {
                    string nombreEstilo;
                    int claveES;

                    nombreEstilo = reader.GetString(0);
                    claveES = (int)reader.GetDecimal(1);

                    ListViewItem item = new ListViewItem();

                    item.Text = nombreEstilo;  // Primera columna
                    item.SubItems.Add(claveES.ToString());   // Segunda columna

                    listViewEstilo.Items.Add(item);
                }
                reader.Close();
                conexion.Close();
            }
            catch (OracleException ex)
            {
                // Mensaje de error si no tiene acceso a la base de datos
                MessageBox.Show(
                    "Error al cargar el contador de Estilos: " + ex.Message,
                    "Aplicación de conexión a base de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }// AUTORES


        // TEXTBOX CATEGORIA
        private void listViewCategoriaLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCategoriaLibro.SelectedItems.Count != 0)
            {
                ListViewItem item = listViewCategoriaLibro.SelectedItems[0];

                textBoxCategoriaLI.Text = item.SubItems[0].Text;         // Primera Columna
                textBoxCategoriaNombre.Text = item.SubItems[1].Text;     // Segunda Columna
                textBoxCategoriaFecha.Text = item.SubItems[2].Text;      // Tercera Columna
                textBoxCategoriaEditorial.Text = item.SubItems[3].Text;  // Cuarta  Columna
                textBoxCategoriaAutor.Text = item.SubItems[4].Text;      // Quinta  Columna
            }
        }

        // TEXTBOX ESTILO
        private void listViewEstiloLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewEstiloLibro.SelectedItems.Count != 0)
            {
                ListViewItem item = listViewEstiloLibro.SelectedItems[0];

                textBoxEstiloLI.Text = item.SubItems[0].Text;         // Primera Columna
                textBoxEstiloNombre.Text = item.SubItems[1].Text;     // Segunda Columna
                textBoxEstiloFecha.Text = item.SubItems[2].Text;      // Tercera Columna
                textBoxEstiloEditorial.Text = item.SubItems[3].Text;  // Cuarta  Columna
                textBoxEstiloAutor.Text = item.SubItems[4].Text;      // Quinta  Columna
            }
        }

        // TEXTBOX AUTORES
        private void listViewAutoresLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAutoresLibro.SelectedItems.Count != 0)
            {
                ListViewItem item = listViewAutoresLibro.SelectedItems[0];

                textBoxAutorLI.Text = item.SubItems[0].Text;         // Primera Columna
                textBoxAutorNombre.Text = item.SubItems[1].Text;     // Segunda Columna
                textBoxAutorFecha.Text = item.SubItems[2].Text;      // Tercera Columna
                textBoxAutorEditorial.Text = item.SubItems[3].Text;  // Cuarta  Columna
            }
        }

        // TEXTBOX EMPLEADO
        private void listViewEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewEmpleado.SelectedItems.Count != 0)
            {
                ListViewItem item = listViewEmpleado.SelectedItems[0];

                textBoxEM.Text = item.SubItems[0].Text;                  // Primera columna
                textBoxNombreEmpleado.Text = item.SubItems[1].Text;      // Segunda columna
                textBoxApellidosEmpleado.Text = item.SubItems[2].Text;   // Tercera columna
                textBoxTurnoEmpleado.Text = item.SubItems[3].Text;       // Cuarta columna
            }
        }

        // TEXTBOX USUARIO
        private void listViewUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewUsuario.SelectedItems.Count != 0)
            {
                ListViewItem item = listViewUsuario.SelectedItems[0];

                textBoxUS.Text = item.SubItems[0].Text;                 // Primera columna
                textBoxNombreUsuario.Text = item.SubItems[1].Text;      // Segunda columna
                textBoxApellidosUsuario.Text = item.SubItems[2].Text;   // Tercera columna
                textBoxDireccionUsuario.Text = item.SubItems[3].Text;   // Cuarta columna
            }
        }

        //------------------------

        // BOTON ACTUALIZAR EMPLEADO
        private void buttonActualizarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conexion;
                OracleCommand comando;

                conexion = new OracleConnection();
                conexion.ConnectionString =
                    "Persist Security Info=False; " +
                    "Data Source=172.18.35.50/bddam; User ID=BD_DMARCO; Password=47030791T";
                conexion.Open();

                comando = new OracleCommand();
                comando.Connection = conexion;

                comando.CommandText = "UPDATE Empleado SET " +
                    "EM#='"+ textBoxEM.Text + "'," +
                    "NombreEmpleado='" + textBoxNombreEmpleado.Text + "'," +
                    "ApellidosEmpleado='" + textBoxApellidosEmpleado.Text + "'," +
                    "Turno='" + textBoxTurnoEmpleado.Text + "'" +
                    "WHERE EM#='" + textBoxEM.Text + "'";

                comando.ExecuteNonQuery();

                conexion.Close();

                cargarEmpleados();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(
                    "Error al actualizar Empleado: " + ex.Message,
                    "Aplicación de conexión a base de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // BOTON BORRAR EMPELADO
        private void buttonBorrarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                // 0. Declaración de los objetos para conexión base datos con ADO
                OracleConnection conexion;
                OracleCommand comando;

                // 1. Crear la cadena de conexión a la base de datos
                conexion = new OracleConnection();
                conexion.ConnectionString =
                    "Persist Security Info=False; " +
                    "Data Source=172.18.35.50/bddam; User ID=BD_DMARCO; Password=47030791T";
                conexion.Open();

                // 2. Preparar la consulta
                comando = new OracleCommand();
                comando.Connection = conexion;

                comando.CommandText = "DELETE FROM Empleado WHERE " +
                    "EM#='" + textBoxEM.Text + "'";

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
                    "Error al borrar Empleado: " + ex.Message,
                    "Aplicación de conexión a base de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // BOTON CREAR EMPLEADO
        private void buttonCrearEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conexion;
                OracleCommand comando;

                conexion = new OracleConnection();
                conexion.ConnectionString =
                    "Persist Security Info=False; " +
                    "Data Source=172.18.35.50/bddam; User ID=BD_DMARCO; Password=47030791T";
                conexion.Open();

                comando = new OracleCommand();
                comando.Connection = conexion;

                comando.CommandText = "INSERT INTO Empleado VALUES (" +
                    "'" + textBoxEM.Text + "'," +
                    "'" + textBoxNombreEmpleado.Text + "'," +
                    "'" + textBoxApellidosEmpleado.Text + "'," +
                    "'" + textBoxTurnoEmpleado.Text + "'";

                comando.ExecuteNonQuery();

                conexion.Close();

                cargarEmpleados();
            }
            catch (OracleException ex)
            {
                // Mensaje de error si no tiene acceso a la base de datos
                MessageBox.Show(
                    "Error al crear Empleado: " + ex.Message,
                    "Aplicación de conexión a base de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //--
        // BOTON ACTUALIZAR USUARIO
        private void buttonActualizarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conexion;
                OracleCommand comando;

                conexion = new OracleConnection();
                conexion.ConnectionString =
                    "Persist Security Info=False; " +
                    "Data Source=172.18.35.50/bddam; User ID=BD_DMARCO; Password=47030791T";
                conexion.Open();

                comando = new OracleCommand();
                comando.Connection = conexion;

                comando.CommandText = "UPDATE Usuario SET " +
                    "US#='" + textBoxUS.Text + "'," +
                    "NombreUsuario='" + textBoxNombreUsuario.Text + "'," +
                    "ApellidosUsuario='" + textBoxApellidosUsuario.Text + "'," +
                    "DireccionUsuario='" + textBoxDireccionUsuario.Text + "'" +
                    "WHERE US#='" + textBoxUS.Text + "'";

                comando.ExecuteNonQuery();

                conexion.Close();

                cargarUsuarios();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(
                    "Error al actualizar Usuario: " + ex.Message,
                    "Aplicación de conexión a base de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // BOTON BORRAR USUARIO
        private void buttonBorrarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conexion;
                OracleCommand comando;

                conexion = new OracleConnection();
                conexion.ConnectionString =
                    "Persist Security Info=False; " +
                    "Data Source=172.18.35.50/bddam; User ID=BD_DMARCO; Password=47030791T";
                conexion.Open();

                comando = new OracleCommand();
                comando.Connection = conexion;

                comando.CommandText = "DELETE FROM Usuario WHERE " +
                    "US#='" + textBoxUS.Text + "'";

                comando.ExecuteNonQuery();

                conexion.Close();

                cargarEmpleados();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(
                    "Error al borrar Usuario: " + ex.Message,
                    "Aplicación de conexión a base de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // BOTON CREAR USUARIO
        private void buttonCrearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conexion;
                OracleCommand comando;

                conexion = new OracleConnection();
                conexion.ConnectionString =
                    "Persist Security Info=False; " +
                    "Data Source=172.18.35.50/bddam; User ID=BD_DMARCO; Password=47030791T";
                conexion.Open();

                comando = new OracleCommand();
                comando.Connection = conexion;

                comando.CommandText = "INSERT INTO Usuario VALUES (" +
                    "'" + textBoxUS.Text + "'," +
                    "'" + textBoxNombreUsuario.Text + "'," +
                    "'" + textBoxApellidosUsuario.Text + "'," +
                    "'" + textBoxDireccionUsuario.Text + "'";

                comando.ExecuteNonQuery();

                conexion.Close();

                cargarEmpleados();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(
                    "Error al crear Usuario: " + ex.Message,
                    "Aplicación de conexión a base de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //--

        // BOTON CARGAR LIBROS
        private void buttonCargarDatos_Click_1(object sender, EventArgs e)
        {
            cargarEstilos();
            cargarAutores();
            cargarCategorias();
        }

        // BOTON CARGAR PERSONAS
        private void buttonCargarPersonas_Click(object sender, EventArgs e)
        {
            cargarEmpleados();
            cargarUsuarios();
            MessageBox.Show("Usuarios y Empleados cargados con éxito",
                "Aplicación de base de datos",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // BOTON CERRAR
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // BOTON ACERCA DE
        private void buttonAcercaDe_Click(object sender, EventArgs e)
        {
            FormAcercaDe formAcerca;

            formAcerca = new FormAcercaDe();
            formAcerca.ShowDialog();
        }

        private void buttonCargarPrestamos_Click(object sender, EventArgs e)
        {
            cargarPrestamos();
        }
    }
}