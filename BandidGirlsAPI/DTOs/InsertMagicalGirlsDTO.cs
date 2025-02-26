using System.ComponentModel.DataAnnotations;

namespace BandidGirlsAPI.DTOs
{
    public class InsertMagicalGirlsDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Age { get; set; }

        [Required]
        public string Origun_City { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public string Contract_Date { get; set; }
    }
}
