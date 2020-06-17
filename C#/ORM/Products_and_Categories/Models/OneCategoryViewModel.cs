using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Products_and_Categories.Models
{
    [NotMapped]
    public class OneCategoryViewModel
    {
        public Categories Category { get; set; }
        public List<Product> AllProductsForCategory { get; set; }
        public int ProductIdToAdd { get; set; }
    }
}