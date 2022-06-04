using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BootCamp_API_REST_Clase17.Models
{
    public class Productos
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Double Precio { get; set; }

        // Clave Externa
        [ForeignKey("Proveedor")]
        public int IdProveedor { get; set; }
        public Proveedores? Proveedor { get; set; }
        
    }
}
