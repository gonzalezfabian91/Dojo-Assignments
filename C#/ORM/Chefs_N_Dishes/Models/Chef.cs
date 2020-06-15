using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Chefs_N_Dishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId{get;set;}

        [Required]
        [Display(Name = "First Name")]
        public string FirstName {get;set;}

        [Required]
        [Display(Name = "Last Name")]
        public string LastName {get;set;}

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime Birthday {get;set;}

        public List<Dishes> CreatedDishes {get;set;} = null;
    }
}