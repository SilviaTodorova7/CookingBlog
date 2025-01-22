using CookingBlog.Services.Interfaces;
using CookingBlog.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CookingBlog.Controllers
{
    public class RecipeController : Controller
    {
        private readonly IRecipeService recipeService;

        public RecipeController(IRecipeService recipeService)
        {
            this.recipeService = recipeService;
        }
        public async Task<IActionResult> All()
        {
            ICollection<RecipeViewModel> allRecipesViewModel = await this.recipeService.AllRecipesAsync();
            
            return View(allRecipesViewModel);
        }
    }
}
