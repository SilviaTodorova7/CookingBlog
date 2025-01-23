using CookingBlog.Services.Interfaces;
using CookingBlog.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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

        public async Task<IActionResult> Details(int id)
        {
            try
            {
                RecipeDetailsViewModel model = await this.recipeService
                .ViewDetailsAsync(id);
                return View(model);
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "An error occured while trying to view recipe details. Plaese try again later or contact administrator!");
                return RedirectToAction("All", "Recipe");
            }
        }
    }
}
