using System.Collections.Generic;

namespace Chefs_N_Dishes.Models
{
    public class IndexViewModel
    {
        public Dishes Dish {get;set;}
        public Chef Chefs {get;set;}
        public List<Chef> AllChefs {get;set;}
    }
}