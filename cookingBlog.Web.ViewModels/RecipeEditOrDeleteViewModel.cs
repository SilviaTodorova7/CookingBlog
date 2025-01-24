using System.ComponentModel.DataAnnotations;
using static CookingBlog.Common.EntityValidationConstants.Recipe;

namespace CookingBlog.Web.ViewModels
{
    public class RecipeEditOrDeleteViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(ImageUrlMaxLength, MinimumLength = ImageUrlMinLength)]
        public string ImageUrl { get; set; } = null!;
    }
}
