using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wedding_Planner.Models
{
    [NotMapped]
    public class Login
    {
        [Required]
        [EmailAddress]
        public string LoginEmail {get;set;}

        [Required]
        [DataType(DataType.Password)]
        public string LoginPassword {get;set;}
    }
}