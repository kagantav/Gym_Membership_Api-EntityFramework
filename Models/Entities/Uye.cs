using System.ComponentModel.DataAnnotations;

namespace Gym_Membership.Models.Entities
{
    public class Uye
    {
        [Key]
        public int? Id { get; set; }
        public string? UyeAdi { get; set; }
        public string? UyeSoyadi { get; set; }
        public DateTime? UyelikBaslangicTarihi { get ; set; }
        public DateTime? UyelikBitisTarihi { get; set; }

    }
}
