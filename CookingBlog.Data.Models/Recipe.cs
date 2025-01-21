using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CookingBlog.Common.EntityValidationConstants.Recipe;

namespace CookingBlog.Data.Models
{
    public class Recipe
    {
        public Recipe()
        {
            this.IsActive = true;
            this.Comments = new HashSet<Comment>();
            this.Ratings = new HashSet<Rating>();
            this.Rating = this.Ratings.Where(r => r.RecipeId == this.Id).Average(r => r.Value).ToString();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; } = null!;

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        [Required]
        public Category Category { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Author))]
        public string AuthorId { get; set; } = null!;

        [Required]
        public IdentityUser Author { get; set; } = null!;

        [Required]
        [StringLength(ImageUrlMaxLength, MinimumLength = ImageUrlMinLength)]
        public string ImageUrl { get; set; } = null!;

        public bool IsActive { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public string Rating { get; set; } = null!;

        public ICollection<Rating> Ratings { get; set; }
    }

}
