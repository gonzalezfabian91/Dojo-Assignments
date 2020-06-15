using System;
using System.ComponentModel.DataAnnotations;

namespace Chefs_N_Dishes.Models
{
    public class Dishes
    {
        [Key]
        public int DishId {get;set;}

        [Required]
        [Display(Name = "Name of Dish")]
        public string Name {get;set;}

        [Required]
        [Range(0, int.MaxValue)]
        [Display(Name = "Number of Calories")]
        public int Calories{get;set;}

        [Required]
        [Range(1,5)]
        [Display(Name = "Tastiness")]
        public int Tastiness {get;set;}

        [Required]
        [Display(Name = "Description")]
        public string Description {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        [Display(Name = "Chef")]
        public int ChefId {get;set;}
        public Chef Creator {get;set;}

    }
}