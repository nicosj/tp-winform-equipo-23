using System;

namespace Dominio
{
    public class Imagen
    {
        /*Id int IDENTITY(1,1) not null,
        IdArticulo int not null,
        ImagenUrl varchar(1000) not null*/
        public int Id { get; set; }
        public int IdArticulo { get; set; }
        public String ImagenUrl { get; set; }
    }
}