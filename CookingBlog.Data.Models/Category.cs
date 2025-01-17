using System.ComponentModel.DataAnnotations;

namespace CookingBlog.Data.Models
{
    public class Category
    {
        public Category()
        {
            this.Recipes = new HashSet<Recipe>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = null!;

        public ICollection<Recipe> Recipes { get; set; }
    }
}
