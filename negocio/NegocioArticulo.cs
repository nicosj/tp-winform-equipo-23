using System;
using System.Collections.Generic;
using ConexionDB;
using Dominio;
using negocio;

namespace negocio
{
<<<<<<< HEAD
    public class NegocioArticulo
    {
        public bool guardar(Articulo nuevo)
        {
            DB db = new DB();
            try
            {
                if(nuevo.Id!=0){
                db.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)");
                db.comando.Parameters.Clear();
                db.comando.Parameters.AddWithValue("@Codigo", nuevo.Codigo);
                db.comando.Parameters.AddWithValue("@Nombre", nuevo.Nombre);
                db.comando.Parameters.AddWithValue("@Descripcion", nuevo.Descripcion);
                db.comando.Parameters.AddWithValue("@IdMarca", nuevo.IdMarca);
                db.comando.Parameters.AddWithValue("@IdCategoria", nuevo.IdCategoria);
                db.comando.Parameters.AddWithValue("@Precio", nuevo.Precio);
                }
                else
                { 
                    db.setearConsulta("INSERT into ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,Precio) values ('" + nuevo.Codigo + "','" + nuevo.Nombre + "','" + nuevo.Descripcion + "'," + nuevo.IdMarca + "," + nuevo.IdCategoria + "," + nuevo.Precio + ")");
                }
                return db.ejecutarAccion();
                
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
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
=======
	public class NegocioArticulo
	{
		public List<Articulo> listar()
		{
			List<Articulo> articulos = new List<Articulo>();
			DB db = new DB();

			try
			{
				db.setearConsulta("SELECT Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio FROM ARTICULOS");
				db.ejecutarLectura();

				while (db.Lector.Read())
				{
					Articulo aux = new Articulo();
					aux.Id = db.Lector.GetInt32(0);
					aux.Codigo = db.Lector.GetString(1);
					aux.Nombre = db.Lector.GetString(2);
					aux.Descripcion = db.Lector.GetString(3);
					aux.IdMarca = (int)db.Lector["IdMarca"];
					aux.IdCategoria = (int)db.Lector["IdCategoria"];
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
		public void eliminar(int id)
		{
			try
			{
				DB datos = new DB();
				datos.setearConsulta("DELETE FROM ARTICULOS where id= @id");
				datos.setearParametro("@id", id);
				datos.ejecutarAccion();
			}
			catch (Exception ex)
			{

				throw ex;
			}

		}



	}
>>>>>>> 59269065559d8f54287fd87770c4eea6ce880f7a
}