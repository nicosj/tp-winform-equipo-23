using System.Collections.Generic;
using ConexionDB;
using Dominio;

namespace negocio
{
    public class NegocioImagen
    {
        public List<Imagen> listar()
        {
            List<Imagen> imagen  = new List<Imagen>();
            DB db = new DB();

            try
            {
                db.setearConsulta("SELECT Id, IdArticulo, ImagenUrl FROM IMAGENES");
                db.ejecutarLectura();

                while (db.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.Id = db.Lector.GetInt32(0);
                    aux.IdArticulo = (int)db.Lector["IdArticulo"];
                    aux.ImagenUrl = db.Lector.GetString(2);
                    imagen.Add(aux);
                }
                return imagen;

            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}