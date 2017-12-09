using RecipeCard.Models;

namespace RecipeCard
{
    public interface IRecipeReader
    {
        Recipe ReadFromUrl(string url);
    }
}
