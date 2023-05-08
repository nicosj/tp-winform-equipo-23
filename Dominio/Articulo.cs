using System;
using System.ComponentModel;

namespace Dominio
{
    public class Articulo
    {
    
        
        public int Id { get; set; }
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }


        [DisplayName("Categoria")]
        public int IdCategoria{ get; set; }
        [DisplayName("Marca")]
        public int IdMarca { get; set; }
        public decimal Precio { get; set; }
    }
}