using SistemadeClubDeportivo.Dto;
using System.ComponentModel.DataAnnotations;

namespace SistemadeClubDeportivo.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public Rolenum Rol { get; set; }


        public virtual List<Pago>? Pagos { get; set; }
    }
}
