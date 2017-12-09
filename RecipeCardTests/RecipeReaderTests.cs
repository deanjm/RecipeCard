using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipeCard;
using System;

namespace RecipeCardTests
{
    [TestClass]
    [TestCategory("RecipeReader")]
    public class RecipeReaderTests
    {
        [TestMethod]
        public void ReadFromUrlReturnsARecipe()
        {
            var reader = new RecipeReader();

            var recipe = reader.ReadFromUrl("http://localhost");
            Assert.IsNotNull(recipe);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ReadFromUrlEmptyUrlThrowsArgumentException()
        {
            var reader = new RecipeReader();

            var recipe = reader.ReadFromUrl(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ReadFromurlInvalidUrlThrowsArgumentException()
        {
            var reader = new RecipeReader();

            var recipe = reader.ReadFromUrl("Not a url");
        }
    }
}
