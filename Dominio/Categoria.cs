using System;

namespace Dominio
{
    public class Categoria
    {
        /*
         * [Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
         */
        public int id { get; set; }
        public String descripcion { get; set; }
    }
}