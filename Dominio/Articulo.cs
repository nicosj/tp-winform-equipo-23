using System;

namespace Dominio
{
    public class Articulo
    {
    
        
        public int Id { get; set; }
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        
        public int IdCategoria{ get; set; }
        public int IdMarca { get; set; }
        public decimal Precio { get; set; }
    }
}