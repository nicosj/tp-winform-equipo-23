using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ConexionDB;
using Dominio;
using negocio;

namespace negocio
{
    public class NegocioCategoria
    {
        public List<Categoria> listar()
        {
            List<Categoria> categorias = new List<Categoria>();
            DB db = new DB();

            try
            {

                db.setearConsulta("SELECT Id, Descripcion FROM CATEGORIAS");
                db.ejecutarLectura();

                while (db.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)db.Lector["Id"];
                    aux.Descripcion = (string)db.Lector["Descripcion"];

                    categorias.Add(aux);
                }
                db.cerrarConexion();
                return categorias;
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

        public void eliminar(int id)
        {
            try
            {
                DB datos = new DB();
                datos.setearConsulta("DELETE FROM CATEGORIAS where id= @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}