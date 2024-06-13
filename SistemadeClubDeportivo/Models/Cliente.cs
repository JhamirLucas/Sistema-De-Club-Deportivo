using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace SistemadeClubDeportivo.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? NomTutor { get; set; }
        public int NumCelular { get; set; }
        public int NumCelTutor { get; set; }
        public decimal MontoRegistro { get; set; }
        public DateTime FechaNaci { get; set; }
        public DateTime FechaReg { get; set; }

        public virtual List<Pago>? Pagos { get; set; }

        public int PersonalId { get; set; }

        public virtual Personal? Personal { get; set; }
    }
}
