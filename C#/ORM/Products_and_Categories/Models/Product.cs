using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Products_and_Categories.Models
{
    public class Product
    {
        [Key]
        public int ProductId {get;set;}

        [Required]
        [Display(Name = "Name")]
        public string Name {get;set;}

        [Required]
        [Display(Name = "Description")]
        public string Description {get;set;}

        [Required]
        [Display(Name = "Price")]
        public double Price {get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<Associations> Categories {get;set;}

    }
}