using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CookingBlog.Web.ViewModels
{
    public class RecipeDetailsViewModel
    {
        public RecipeDetailsViewModel()
        {
            this.Comments = new HashSet<CommentViewModel>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Category { get; set; } = null!;

        public string Author { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public ICollection<CommentViewModel> Comments { get; set; }

        public string Rating { get; set; } = null!;
    }
}
