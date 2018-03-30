using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeCard.Models
{
    public class Recipe
    {
        public string Name { get; set; }
        public IList<string> Ingredients { get; set; }
        public IList<string> Instructions { get; set; }
        public string Yield { get; set; }
    }
}
