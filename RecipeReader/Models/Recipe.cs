using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeCard.Models
{
    public class Recipe
    {
        public DateTime Duration { get; set; }
        public string CookingMethod { get; set; }
        public object NutritionInformation { get; set; }
        public string Category { get; set; }
        public string Cuisine { get; set; }
        public IList<string> Ingredients { get; set; }
        public IList<string> Instructions { get; set; }
        public string Yield { get; set; }
    }
}
