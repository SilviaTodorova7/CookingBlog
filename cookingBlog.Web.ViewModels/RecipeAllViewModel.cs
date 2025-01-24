namespace CookingBlog.Web.ViewModels
{
    public class RecipeAllViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Author { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public string Rating { get; set; } = null!;
    }
}
