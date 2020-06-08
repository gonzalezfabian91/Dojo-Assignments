using System.ComponentModel.DataAnnotations;

namespace Dojo_Survey_with_Validations.Models
{
    public class Survey
    {
        [Required]
        [MinLength(2)]
        public string Name {get;set;}
        [Required]
        public string Location{get;set;}
        [Required]
        public string Language{get;set;}
        [MinLength(20)]
        public string Message{get;set;}
    }
}