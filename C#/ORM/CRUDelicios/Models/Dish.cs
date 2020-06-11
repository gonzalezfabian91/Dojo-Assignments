using System.ComponentModel.DataAnnotations;

namespace CRUDelicios.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get;set;}

        [Required]
        [MinLength(2, ErrorMessage = "Must be at least 2 characters long")]
        [Display]
    }
}