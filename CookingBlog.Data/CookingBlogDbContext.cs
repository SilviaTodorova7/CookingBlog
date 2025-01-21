using CookingBlog.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CookingBlog.Data
{
    public class CookingBlogDbContext : IdentityDbContext<IdentityUser>
    {
        public CookingBlogDbContext(DbContextOptions<CookingBlogDbContext> options)
            : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Recipe> Recipes { get; set; } = null!;

        public DbSet<Comment> Comments { get; set; } = null!;

        public DbSet<Rating> Ratings { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Recipe>()
                .HasOne(r => r.Category)
                .WithMany(c => c.Recipes)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Comment>()
                .HasOne(c => c.Recipe)
                .WithMany(r => r.Comments)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Rating>()
                .HasOne(r => r.Recipe)
                .WithMany(r => r.Ratings)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
