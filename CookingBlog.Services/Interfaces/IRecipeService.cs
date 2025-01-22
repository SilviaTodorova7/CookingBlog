using CookingBlog.Web.ViewModels;

namespace CookingBlog.Services.Interfaces
{
    public interface IRecipeService
    {
        Task<ICollection<RecipeViewModel>> AllRecipesAsync();

    }
}
