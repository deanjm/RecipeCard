using RecipeCard.Models;
using System;

namespace RecipeCard
{
    public class RecipeReader : IRecipeReader
    {
        public Recipe ReadFromUrl(string url)
        {
            if (string.IsNullOrEmpty(url)) throw new ArgumentException(strings.EmptyUrlExceptionMessage, "url");

            var isValidUrl = Uri.TryCreate(url, UriKind.Absolute, out Uri recipeUri) && (recipeUri.Scheme == Uri.UriSchemeHttp || recipeUri.Scheme == Uri.UriSchemeHttps);
            if (!isValidUrl) throw new ArgumentException(strings.InvalidUrlExceptionmessage, "url");

            return new Recipe();
        }
    }
}
