using System.ComponentModel.DataAnnotations;

namespace CookingBlog.Web.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
