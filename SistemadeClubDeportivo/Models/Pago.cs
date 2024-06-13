using System.ComponentModel.DataAnnotations;

namespace SistemadeClubDeportivo.Models
{
    public class Pago
    {
        [Key]
        public int Id { get; set; }
        public int Anio { get; set; }
        public int Fecha { get; set; }
        public int Mes { get; set; }
        public int NroRecibo { get; set; }
        public int TotalPago { get; set; }

        public int MyProperty { get; set; }

        public int UsuarioId { get; set; }
        public virtual Usuario? Usuario { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente? Cliente { get; set; }
    }
}
