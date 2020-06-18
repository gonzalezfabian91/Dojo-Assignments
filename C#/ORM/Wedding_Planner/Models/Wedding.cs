using System.ComponentModel.DataAnnotations;

namespace Wedding_Planner.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId {get;set;}

        [Required]
        [Display(Name = "Wedder One")]
        public string Bride {get;set;}

        [Required]
        [Display(Name = "Wedder Two")]
        public string Groom {get;set;}
    }
}