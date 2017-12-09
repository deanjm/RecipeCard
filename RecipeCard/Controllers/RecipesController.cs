using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RecipeCard.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class RecipesController : Controller
    {
        [HttpPost]
        [ActionName("Read")]
        public IActionResult Read(string url)
        {
            return Json("Not implemented");
        }
    }
}