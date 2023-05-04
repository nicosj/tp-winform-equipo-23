using System;
using System.Collections.Generic;
using ConexionDB;
using Dominio;
using negocio;

namespace negocio
{
    public class NegocioArticulo
    {
        public List<Articulo> listar( )
        {
            List<Articulo> articulos = new List<Articulo>();
            DB db = new DB();
            
            try
            {   db.setearConsulta("SELECT Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio FROM ARTICULOS");
                db.ejecutarLectura();
                
                while (db.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = db.Lector.GetInt32(0);
                    aux.Codigo = db.Lector.GetString(1);
                    aux.Nombre = db.Lector.GetString(2);
                    aux.Descripcion = db.Lector.GetString(3);
                    aux.IdMarca = (int)db.Lector["IdMarca"];
                    aux.IdCategoria =(int) db.Lector["IdCategoria"];
                    aux.Precio = (decimal)db.Lector["Precio"];
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