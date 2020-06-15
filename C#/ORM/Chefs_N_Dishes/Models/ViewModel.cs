using System.Collections.Generic;
using Chefs_N_Dishes.Models;
using System;

namespace Chefs_N_Dishes.Models
{
    public class ViewModel
    {
        public Dishes Dish {get;set;}
        public Chef Chefs {get;set;}
        public List<Chef> AllChefs {get;set;}
    }
}