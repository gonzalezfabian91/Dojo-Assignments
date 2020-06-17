using System;
using System.ComponentModel.DataAnnotations;

namespace Products_and_Categories.Models
{
    public class Associations
    {
        [Key]
        public int AssociationId {get;set;}

        public int ProductId {get;set;}

        public int CategoryId {get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public Product Product {get;set;}

        public Categories Category {get;set;}
    }
}