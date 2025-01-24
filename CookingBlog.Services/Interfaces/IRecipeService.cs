using CookingBlog.Web.ViewModels;

namespace CookingBlog.Services.Interfaces
{
    public interface IRecipeService
    {
        Task<ICollection<RecipeAllViewModel>> AllRecipesAsync();

        Task<RecipeDetailsViewModel> ViewDetailsAsync(int id);

        Task<RecipeEditOrDeleteViewModel> FindRecipeToEditOrDeleteAsync(int id);

        Task EditRecipeAsync(RecipeEditOrDeleteViewModel model, int id, string userId);

        Task DeleteRecipeAsync(int id, string userId);

        Task<ICollection<CategoryViewModel>> GetCategoriesAsync();

        Task AddNewRecipeAsync(RecipeAddViewModel model, string userId);
    }
}
