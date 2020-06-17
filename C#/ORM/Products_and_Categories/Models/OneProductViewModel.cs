using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Products_and_Categories.Models
{
    [NotMapped]
    public class OneProductViewModel
    {
        public Product Product {get;set;}
        public List<Categories> AllCategoriesForProduct {get;set;}
        public int CategoryIdToAdd {get;set;}
    }
}