using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using static CookingBlog.Common.EntityValidationConstants.Category;

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
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; } = null!;

        public ICollection<Recipe> Recipes { get; set; }
    }
}
