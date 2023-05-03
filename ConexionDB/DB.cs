using System;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace ConexionDB
{
    public class DB
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public SqlDataReader Lector
        {
            get { return lector; }
        }
        public DB()
        {
            conexion= new SqlConnection ("server=127.0.0.1;database=CATALOGO_P3_DB;uid=sa;pwd=Nicosj999@;encrypt=false");
            comando = new SqlCommand();
        }
        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void setearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }

    

        /*public void porla()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader leer;
            //CADENA DE CONEXION NICO//
                
            //CADENA DE CONEXION SEBA//
            //conn.ConnectionString = "server=localhost\\LABO3; database=CATALOGO_P3_DB; integrated security=false; user=sa; password=123xx;";
            //cadena de conexion erik//
            //conn.ConnectionString = "server=localhost\\lab3sv; database=catalogo_p3_db; integrated security=false; user=sa; password=0856;";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio FROM ARTICULOS";
            command.Connection = conn;
        }*/
    }
}