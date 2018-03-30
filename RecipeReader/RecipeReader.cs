using HtmlAgilityPack;
using RecipeCard.Models;
using System;
using System.Net;
using System.Threading.Tasks;

namespace RecipeCard
{
    public class RecipeReader : IRecipeReader
    {
        public const string RECIPE_SELECTOR = "//*[@itemtype='http://schema.org/Recipe']";

        public Recipe ReadFromUrl(string url)
        {
            if (string.IsNullOrEmpty(url)) throw new ArgumentException(strings.EmptyUrlExceptionMessage, "url");

            var isValidUrl = VerifyUrl(url);
            if (!isValidUrl) throw new ArgumentException(strings.InvalidUrlExceptionmessage, "url");

            var htmlDoc = GetHtmlFromUri(url);

            return ProcessRecipeNode(htmlDoc);
        }

        public bool VerifyUrl(string url) => 
            Uri.TryCreate(url, UriKind.Absolute, out Uri recipeUri) 
            && (recipeUri.Scheme == Uri.UriSchemeHttp || recipeUri.Scheme == Uri.UriSchemeHttps);

        public HtmlDocument GetHtmlFromUri(string website)
        {
            var htmlDoc = new HtmlWeb();
            return htmlDoc.Load(website);
        }

        public Recipe ProcessRecipeNode(HtmlDocument htmlDoc)
        {
            var recipeNode = htmlDoc.DocumentNode.SelectSingleNode(RECIPE_SELECTOR);
            
            if (recipeNode == null) return null;

            var name = recipeNode.SelectSingleNode("//*[@itemprop='name']")?.InnerText;
            var yield = recipeNode.SelectSingleNode("//*[@itemprop='recipeYield']")?.Attributes["content"]?.Value;

            return new Recipe
            {
                Name = name,
                Yield = yield
            };
        }
    }
}
