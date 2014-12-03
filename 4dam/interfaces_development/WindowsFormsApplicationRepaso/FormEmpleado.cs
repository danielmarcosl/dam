using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace WindowsFormsApplicationRepaso
{
    public partial class FormEmpleado : Form
    {
        public FormEmpleado()
        {
            InitializeComponent();
        }

        private void cargarEmpleados()
        {
            BaseDatos bd = new BaseDatos();

            bd.Abrir();
            bd.EjecutarConsulta(TipoConsulta.SELECT,
                "SELECT Nombre FROM Empleado", comboBoxEmpleado);
            bd.Cerrar();
        }

        private void cargarEmpleadosDetalle()
        {
            BaseDatos bd = new BaseDatos();
            OracleDataReader reader;

            bd.Abrir();
            reader = bd.EjecutarConsulta(TipoConsulta.SELECT,
                "SELECT EM#,Nombre,Edad,Domicilio FROM Empleado");

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();

                item.Text = reader.GetString(0);
                item.SubItems.Add(reader.GetString(1));
                item.SubItems.Add(reader.GetInt32(2).ToString());
                item.SubItems.Add(reader.GetString(3));

                listViewEmpleado.Items.Add(item);
            }
            bd.Cerrar();
        }

        private void buttonCargarDatos_Click(object sender, EventArgs e)
        {
            cargarEmpleados();
        }

        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            cargarEmpleados();
            cargarEmpleadosDetalle();
        }

        private void listViewEmpleado_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewEmpleado.SelectedItems.Count != 0)
            {
                ListViewItem item = listViewEmpleado.SelectedItems[0];
                FormEmpleadoDetalle formHijo = new FormEmpleadoDetalle();

                // formHijo.FijarEM(item.SubItems[0].Text);
                formHijo.EM = item.SubItems[0].Text;
                formHijo.FijarNombre(item.SubItems[1].Text);
                formHijo.FijarEdad(item.SubItems[2].Text);
                formHijo.FijarDomicilio(item.SubItems[3].Text);
                
                DialogResult resultado = formHijo.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    MessageBox.Show("ESTOY EN EL PADRE Y HA PULSADO OK");
                }
                else
                {
                    if (resultado == DialogResult.Cancel)
                    {
                        MessageBox.Show("ESTOY EN EL PADRE Y HA PULSADO CANCEL");
                    }
                }
            }
        }
    }
}
