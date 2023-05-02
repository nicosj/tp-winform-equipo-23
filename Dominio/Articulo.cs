using System;

namespace Dominio
{
    public class Articulo
    {
        /*
     [Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](150) NULL,
	[IdMarca] [int] NULL,
	[IdCategoria] [int] NULL,
	[Precio] [money] NULL,
 CONSTRAINT [PK_ARTICULOS]
         */
        
        public int Id { get; set; }
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        
        public int IdCategoria{ get; set; }
        public int IdMarca { get; set; }
        public decimal Precio { get; set; }
    }
}