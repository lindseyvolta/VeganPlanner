﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VeganPlanner.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        [Display(Name = "Is a Recipe")]
        public bool IsRecipe { get; set; }
        [Display(Name = "Serving Size")]
        public decimal ServingSize { get; set; }
        [Display(Name = "Serving Units")]
        public string ServingUnits { get; set; }
        public string Category { get; set; }
        public string UserID { get; set; }
        [Display(Name = "Cals/Serving")]
        public int CaloriesPerServing { get; set; }
        [Display(Name = "Protein/Serving (g)")]
        public int ProteinPerServing { get; set; }
        [Display(Name = "Pantry Item")]
        public bool IsPantryItem { get; set; }
        [Display(Name = "GF")]
        public bool IsGF { get; set; }

        public int? RecipeID { get; set; }
        public Recipe recipe { get; set; }
    }
}
