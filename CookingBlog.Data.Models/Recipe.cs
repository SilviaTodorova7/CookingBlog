using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookingBlog.Data.Models
{
    public class Recipe
    {
        public Recipe()
        {
            this.IsActive = true;
            this.Comments = new HashSet<Comment>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(2000)]
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
        [StringLength(250)]
        public string ImageUrl { get; set; } = null!;

        public bool IsActive { get; set; }

        public ICollection<Comment> Comments { get; set; }

    }
}
