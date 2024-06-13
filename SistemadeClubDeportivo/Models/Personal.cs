using System.ComponentModel.DataAnnotations;

namespace SistemadeClubDeportivo.Models
{
    public class Personal
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? DiaHorario { get; set; }
        public int HoraHorario { get; set; }
        public int NumCelular { get; set; }

        public virtual List<Cliente>? Clientes { get; set; }

    }
}
