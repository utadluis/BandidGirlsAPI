using System.ComponentModel.DataAnnotations;

namespace BandidGirlsAPI.Model
{
    public class MagicalGirls
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Age { get; set; }

        [Required]
        public string Origun_City { get; set; }
        public string Status { get; set; }

        [Required]
        public string Contract_Date { get; set; }

        public List<Historial> HistorialsDb { get; set; } = new List<Historial>();
    }

}
