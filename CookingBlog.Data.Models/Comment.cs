using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CookingBlog.Common.EntityValidationConstants.Comment;

namespace CookingBlog.Data.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(TitleMaxLength, MinimumLength =TitleMinLength)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength (ContentMaxLength, MinimumLength = ContentMinLength)]
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
