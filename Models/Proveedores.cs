using System.ComponentModel.DataAnnotations;

namespace BootCamp_API_REST_Clase17.Models
{
    public class Proveedores
    {
        [Key]
        public int IdProveedor { get; set; }
        public string Name { get; set; }
    }
}
