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

        public DbSet<Category> Categories { get; set; }

        public DbSet<Recipe> Recipes { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
