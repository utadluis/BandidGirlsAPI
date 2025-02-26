using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BandidGirlsAPI.Model
{
    public class Historial
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public string PreviussState { get; set; }

        [Required]
        public string NewState { get; set; }

        [Required]
        public DateTime ChangeDade { get; set; } = DateTime.UtcNow;

        [ForeignKey("MagicalGirl")]
        public int MagicalGirlId { get; set; }

        public MagicalGirls MagicalGirl { get; set; }


    }

}
