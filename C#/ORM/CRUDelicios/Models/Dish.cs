using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDelicios.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get;set;}

        [Required]
        [MinLength(2, ErrorMessage = "Must be at least 2 Characters long")]
        [Display(Name = "Name of Dish")]
        public string DishName{get;set;}

        [Required]
        [MinLength(2, ErrorMessage = "Must be at least 2 Characters long")]
        [Display(Name = "Name of Chef")]
        public string ChefName{get;set;}

        [Required]
        [Range(0, int.MaxValue)]
        [Display(Name = "# of Calories")]
        public int Calories{get;set;}

        [Required]
        [Range(1,5)]
        [Display(Name = "Tastiness")]
        public int Tastiness{get;set;}

        [Required]
        [MinLength(10, ErrorMessage = "Must be at least 10 Characters long")]
        [Display(Name = "Description")]
        public string Description{get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}