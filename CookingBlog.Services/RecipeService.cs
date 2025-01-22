using CookingBlog.Services.Interfaces;
using CookingBlog.Web.ViewModels;
using CookingBlog.Data;
using Microsoft.EntityFrameworkCore;

namespace CookingBlog.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly CookingBlogDbContext dbContext;
        public RecipeService(CookingBlogDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<ICollection<RecipeViewModel>> AllRecipesAsync()
        {
            ICollection<RecipeViewModel> AllRecipes = await this.dbContext
                .Recipes
                .Select(r => new RecipeViewModel()
                {
                    Title = r.Title,
                    Author = r.Author.Email!,
                    ImageUrl = r.ImageUrl,
                    Rating = r.Ratings.Average(r => r.Value).ToString(),
                }).ToArrayAsync();

            return AllRecipes;
        }
    }
}
