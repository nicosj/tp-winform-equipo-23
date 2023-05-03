using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dominio;

namespace negocio
{
    public class NegocioArticulo
    {
        public List<Articulo> listar()
        {
            List<Articulo> articulos = new List<Articulo>();
            SqlConnection conn = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader leer;
            try
            {
                //conn.ConnectionString = "server=127.0.0.1;database=CATALOGO_P3_DB;uid=sa;pwd=Nicosj999@;encrypt=false";
                conn.ConnectionString = "server=127.0.0.1;database=CATALOGO_P3_DB;uid=sa;pwd=Nicosj999@;encrypt=false";
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio FROM ARTICULOS";
                command.Connection = conn;
                conn.Open();
                leer = command.ExecuteReader();

                while (leer.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = leer.GetInt32(0);
                    aux.Codigo = leer.GetString(1);
                    aux.Nombre = leer.GetString(2);
                    aux.Descripcion = leer.GetString(3);
                    aux.IdMarca = (int)leer["IdMarca"];
                    aux.IdCategoria =(int) leer["IdCategoria"];
                    aux.Precio = (decimal)leer["Precio"];
                    articulos.Add(aux); 
                }
                return articulos;
                
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

    }
}