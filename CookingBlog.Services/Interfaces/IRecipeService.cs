using CookingBlog.Web.ViewModels;

namespace CookingBlog.Services.Interfaces
{
    public interface IRecipeService
    {
        Task<ICollection<RecipeAllViewModel>> AllRecipesAsync();

        Task<RecipeDetailsViewModel> ViewDetailsAsync(int id);

        Task<RecipeEditViewModel> FindRecipeToEditAsync(int id);

        Task EditRecipeAsync(RecipeEditViewModel model, int id, string userId);
    }
}
