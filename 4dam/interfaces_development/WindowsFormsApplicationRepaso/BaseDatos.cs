using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using System.Windows.Forms;

namespace WindowsFormsApplicationRepaso
{
    public enum TipoConsulta { SELECT, INSERT, UPDATE, DELETE };
    
    class BaseDatos
    {
        private OracleConnection conexion;
        private OracleCommand comando;
        
        // Constructor
        public BaseDatos()
        {
            conexion = new OracleConnection();
            comando = new OracleCommand();
        }

        public void Abrir()
        {
            try
            {
                conexion.ConnectionString =
                          "Persist Security Info=False; " +
                          "Data Source=172.18.35.50/bddam; User ID=prueba; Password=prueba;";
                conexion.Open();
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Base Datos - Abrir : Error : " + ex.Message);
            }
        }

        public OracleDataReader EjecutarConsulta(TipoConsulta tipo, string consulta)
        {
            OracleDataReader reader=null;

            comando.Connection = conexion;
            comando.CommandText = consulta;
            switch (tipo)
            {
                case TipoConsulta.SELECT:
                    reader = comando.ExecuteReader();
                    break;
                case TipoConsulta.INSERT:
                    comando.ExecuteNonQuery();
                    break;
                case TipoConsulta.DELETE:
                    comando.ExecuteNonQuery();
                    break;
                case TipoConsulta.UPDATE:
                    comando.ExecuteNonQuery();
                    break;
            }
            return reader;
        }

        public void EjecutarConsulta(TipoConsulta tipo, string consulta,ComboBox combo)
        {
            OracleDataReader reader = null;

            comando.Connection = conexion;
            comando.CommandText = consulta;
            switch (tipo)
            {
                case TipoConsulta.SELECT:
                    reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        combo.Items.Add(reader.GetString(0));
                    }
                    break;
                case TipoConsulta.INSERT:
                    comando.ExecuteNonQuery();
                    break;
                case TipoConsulta.DELETE:
                    comando.ExecuteNonQuery();
                    break;
                case TipoConsulta.UPDATE:
                    comando.ExecuteNonQuery();
                    break;
            }
        }


        public void EjecutarConsulta(TipoConsulta tipo, string consulta, ListView lista)
        {
            //OracleDataReader reader = null;

            //comando.Connection = conexion;
            //comando.CommandText = consulta;
            //switch (tipo)
            //{
            //    case TipoConsulta.SELECT:
            //        reader = comando.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            combo.Items.Add(reader.GetString(0));
            //        }
            //        break;
            //    case TipoConsulta.INSERT:
            //        comando.ExecuteNonQuery();
            //        break;
            //    case TipoConsulta.DELETE:
            //        comando.ExecuteNonQuery();
            //        break;
            //    case TipoConsulta.UPDATE:
            //        comando.ExecuteNonQuery();
            //        break;
            //}
        }
        
        
        public void Cerrar()
        {
            conexion.Close();
        }


        
        

    }
}
