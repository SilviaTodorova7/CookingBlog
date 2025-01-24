using CookingBlog.Services.Interfaces;
using CookingBlog.Web.ViewModels;
using CookingBlog.Data;
using Microsoft.EntityFrameworkCore;
using CookingBlog.Data.Models;

namespace CookingBlog.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly CookingBlogDbContext dbContext;
        public RecipeService(CookingBlogDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<ICollection<RecipeAllViewModel>> AllRecipesAsync()
        {
            ICollection<RecipeAllViewModel> AllRecipes = await this.dbContext
                .Recipes
                .Where(r => r.IsActive)
                .Select(r => new RecipeAllViewModel()
                {
                    Id = r.Id,
                    Title = r.Title,
                    Author = r.Author.Email!,
                    ImageUrl = r.ImageUrl,
                    Rating = r.Ratings.Average(r => r.Value).ToString(),
                }).ToArrayAsync();

            return AllRecipes;
        }

        public async Task DeleteRecipeAsync(int id, string userId)
        {
            Recipe recipeToDelete = await this.dbContext
                .Recipes
                .Where(r => r.IsActive)
                .FirstAsync(r => r.Id == id);

            if (recipeToDelete.AuthorId == userId)
            {
                recipeToDelete.IsActive = false;
                await this.dbContext.SaveChangesAsync();
            }
        }

        public async Task EditRecipeAsync(RecipeEditOrDeleteViewModel model, int id, string userId)
        {
            Recipe recipeToEdit = await this.dbContext
                .Recipes
                .Where(r => r.IsActive)
                .FirstAsync(r => r.Id == id);

            if (recipeToEdit.AuthorId == userId)
            {
                recipeToEdit.Title = model.Title;
                recipeToEdit.Description = model.Description;
                recipeToEdit.ImageUrl = model.ImageUrl;
            
                await this.dbContext.SaveChangesAsync();
            }
        }

        public async Task<RecipeEditOrDeleteViewModel> FindRecipeToEditOrDeleteAsync(int id)
        {
            Recipe recipeToEdit = await this.dbContext
                .Recipes
                .Where (r => r.IsActive)
                .FirstAsync(r => r.Id == id);

            return new RecipeEditOrDeleteViewModel()
            {
                Id = id,
                Title = recipeToEdit.Title,
                Description = recipeToEdit.Description,
                ImageUrl = recipeToEdit.ImageUrl,
            };
        }

        public async Task<RecipeDetailsViewModel> ViewDetailsAsync(int id)
        {
            Recipe recipe = await this.dbContext
                .Recipes
                .Where(r => r.IsActive)
                .Include(r => r.Author)
                .Include(r => r.Category)
                .FirstAsync(r => r.Id == id);

            return new RecipeDetailsViewModel()
            {
                Id= id,
                Title = recipe.Title,
                Author = recipe.Author.Email!,
                ImageUrl = recipe.ImageUrl,
                Category = recipe.Category.Name,
                Rating = recipe.Rating,
                Description = recipe.Description,
                Comments = recipe.Comments.Where(c => c.RecipeId == id).Select(c => new CommentViewModel()
                {
                    Title = c.Title,
                    Author = c.Author.Email!,
                    Content = c.Content,
                }).ToArray()
            };
        }



    }
}
