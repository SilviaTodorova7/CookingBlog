using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CookingBlog.Common.EntityValidationConstants.Rating;

namespace CookingBlog.Data.Models
{
    public class Rating
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(Recipe))]
        public int RecipeId { get; set; }

        [Required]
        public Recipe Recipe { get; set; } = null!;

        [Required]
        [Range(RatingMinLength, RatingMaxLength)]
        public int Value { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; } = null!;

        [Required]
        public IdentityUser User { get; set; } = null!;
    }
}
