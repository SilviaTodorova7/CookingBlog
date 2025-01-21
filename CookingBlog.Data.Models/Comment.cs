using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookingBlog.Data.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength (200)]
        public string Content { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Author))]
        public string AuthorId { get; set; } = null!;

        [Required]
        public IdentityUser Author { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Recipe))]
        public int RecipeId { get; set; }

        [Required]
        public Recipe Recipe { get; set; } = null!;
    }
}
