using Microsoft.EntityFrameworkCore;
using CookingBlog.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CookingBlog.Data.Configurations
{
    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            ICollection<Category> categories = this.GenerateCategories();

            builder.HasData(categories);
        }

        private ICollection<Category> GenerateCategories()
        {
            ICollection<Category> categories = new List<Category>();
            Category category;


            category = new Category()
            {
                Id = 1,
                Name = "Salad",
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 2,
                Name = "Soup",
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 3,
                Name = "Meat Meal",
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 4,
                Name = "Vegetarian",
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 5,
                Name = "Sea food",
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 6,
                Name = "Dessert",
            };

            return categories;
        }
    }
}
