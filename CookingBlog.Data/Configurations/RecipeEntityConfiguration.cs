using CookingBlog.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingBlog.Data.Configurations
{
    public class RecipeEntityConfiguration : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            ICollection<Recipe> recipes = this.GenerateRecipes();

            builder.HasData(recipes);
        }

        private ICollection<Recipe> GenerateRecipes()
        {
            ICollection<Recipe> recipes = new HashSet<Recipe>();
            Recipe recipe;

            recipe = new Recipe()
            {
                Id = 1,
                AuthorId = "cc2bfa35-7ac9-45cd-96e2-0c815b1646f0",
                CategoryId = 1,
                Title = "Салата Цезар",
                Description = "пилешки гърди - 2 бр.\r\nайсберг\r\nчери домати - около 200 г\r\nкраставици - 1 бр.\r\nмайонеза - 3 с.л.\r\nкисело мляко - 3 с.л.\r\nчерен пипер\r\nчервен пипер\r\nсол\r\nлимонов сок\r\nзехтин\r\nкрутони\r\nпармезан\r\nПилешките гърди се овкусяват със сол и черен пипер и се изпичат на скара /или оребрен тиган/. След като изстинат се нарязват на хапки.\r\n\r\nСалатата се почиства, измива се и се накъсва. Прибавят се нарязаните краставица и чери доматки.\r\n\r\nДобавят се пилешките късчета и крутоните.\r\n\r\nВ отделен съд се смесват киселото мляко, майонезата и лимоновия сок. Овкусява се с черен и червен пипер и сол.\r\n\r\nС готовия сос се овкусява салатата Цезар. Най-отгоре се настъргва пармезан.\r\n\r\n",
                ImageUrl = "https://recepti.gotvach.bg/files/lib/600x350/salatacesarpile.webp",
            };
            recipes.Add(recipe);

            recipe = new Recipe()
            {
                Id = 2,
                AuthorId = "c61a4d9b-6baa-408f-8a14-4b54694ab219",
                CategoryId = 4,
                Title = "Нахутени кюфтета",
                Description = "Необходими продукти:\r\n\r\n150 г суров нахут (1 консерва нахут – 400 г)\r\n\r\nсол на вкус\r\n\r\n2 ч. л. чубрица\r\n\r\n1/2 ч. л. джоджен\r\n\r\nщипка черен пипер\r\n\r\nщипка кимион\r\n\r\n1/2 малка глава кр. лук\r\n\r\n2 скилидки чесън\r\n\r\n1/4 връзка магданоз\r\n\r\n1 яйце\r\n\r\n2 с. л. зехтин\r\n\r\n \r\n\r\nНачин на приготвяне:\r\n\r\nСледвайки твърдения на експертите по хранене накисваме нахута за 18-24 часа в топла вода. Водата от накисването се изхвърля. При възможност е желателно да сменяме водата на около 8 часа, за да я поддържаме топла. Когато наливаме вода е необходимо не само да покрием нахута, а да оставим 5-10 см вода за набъбване.\r\n\r\nСваряваме нахута и го прецеждаме. Поставяме го в кухненския робот (ако нямате използвайте ръчна преса или пасатор). Подправяме на вкус с всички подправки, като лука и чесъна наситняваме с нож. Пасираме докато получим паста. Ако сместта е суха при пасиране може да добавим малко вода.\r\n\r\nС ръце или с две лъжици се оформят кюфтета, овъргалят се в брашно (царевично, нахутено, бяло и др.) и се пържат от двете страни докато станат златисти.",
                ImageUrl = "https://azgotvia.eu/wp-content/uploads/2015/03/DSC_0081-1-770x460.jpg",
            };
            recipes.Add(recipe);

            return recipes;
        }
    }
}
