using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemadeClubDeportivo.Dto;
using System.ComponentModel.DataAnnotations;

namespace SistemadeClubDeportivo.Models
{
    public class Usuario
    {
        [Key]
        public int ID { get; set; }

        [Required, MinLength(5)]
        public string? Nombre { get; set; }

        [Required, MinLength(5)]
        [EmailAddress]
        public string? Email { get; set; }

        [Required, MinLength(5)]
        public string? Password { get; set; }

        public Rolenum Rol { get; set; }


        // 1 ----- * : Un usuario reagistra muchos pagos 
        public virtual List<Pago>? Pagos { get; set; }
    }
}
