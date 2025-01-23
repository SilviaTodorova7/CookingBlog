using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CookingBlog.Web.ViewModels
{
    public class CommentViewModel
    {
        public string Title { get; set; } = null!;

        public string Content { get; set; } = null!;

        public string Author { get; set; } = null!;
    }
}
