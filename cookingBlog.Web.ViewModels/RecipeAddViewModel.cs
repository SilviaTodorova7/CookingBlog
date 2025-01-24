using CookingBlog.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CookingBlog.Common.EntityValidationConstants.Recipe;

namespace CookingBlog.Web.ViewModels
{
    public class RecipeAddViewModel
    {
        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(CategoryViewModel))]
        public int CategoryId { get; set; }

        [Required]
        public ICollection<CategoryViewModel> Categories { get; set; } = null!;

        [Required]
        public string AuthorId { get; set; } = null!;

        [Required]
        [StringLength(ImageUrlMaxLength, MinimumLength = ImageUrlMinLength)]
        public string ImageUrl { get; set; } = null!;
    }
}
