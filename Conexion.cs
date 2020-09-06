using System.ComponentModel.DataAnnotations;

namespace RedesApp
{
    public class Conexion
    {
        [Key]
        public int Id { get; set; }
            
        public int distancia { get; set; }

        public int Nodo1Id { get; set; }
        public Nodo Nodo1 { get; set; }
        public int Nodo2Id { get; set; }
        public Nodo Nodo2 { get; set; }

        public bool? activado { get; set; } 
    }
}
