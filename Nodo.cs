using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RedesApp
{
    public class Nodo
    {
        [Key]
        public int Id { get; set; }
        public int nodo { get; set; }
        public bool? activado { get; set; }

    }
}
