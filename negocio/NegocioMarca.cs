using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ConexionDB;
using Dominio;
using negocio;

namespace negocio
{
    public class NegocioMarca
    {
        public List<Marca> listar()
        {
            List<Marca> marcas = new List<Marca>();
            DB db = new DB();

            try
            { 

                db.setearConsulta("SELECT Id, Descripcion FROM MARCAS");
                db.ejecutarLectura();

                while (db.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)db.Lector["Id"];
                    aux.Descripcion =(string)db.Lector["Descripcion"];
                    
                    marcas.Add(aux);
                }
                return marcas;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.cerrarConexion();
            }
        }

    }
}