using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Products_and_Categories.Models
{
    public class Categories
    {
        [Key]
        public int CategoryId {get;set;}

        [Required]
        public string Name {get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<Associations> Products {get;set;}
    }
}