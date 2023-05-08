using System;
using System.Collections.Generic;
using ConexionDB;
using Dominio;
using negocio;

namespace negocio
{
	public class NegocioArticulo
	{
		public List<Articulo> listar()
		{
			List<Articulo> articulos = new List<Articulo>();
			List<Marca> marcas = new List<Marca>();
			List<Categoria> categorias = new List<Categoria>();

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
				db.cerrarConexion();
				return articulos;

			}
			catch (System.Exception ex)
			{
				throw ex;
			}
		}

		public int UltimoId()
		{
			try
			{
                DB db = new DB();
                db.setearConsulta("SELECT TOP 1 Id FROM ARTICULOS ORDER BY Id DESC");
                db.ejecutarLectura();
				if (db.Lector.Read())
				{
					return db.Lector.GetInt32(0);
					
				}
				else
				{
					return 0;
				}

            }
			catch (Exception)
			{

				throw;
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
				datos.cerrarConexion();
			}
			catch (Exception ex)
			{

				throw ex;
			}

		}



	}
}