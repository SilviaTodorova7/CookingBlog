using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CookingBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedRecipes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "ImageUrl", "IsActive", "Rating", "Title" },
                values: new object[,]
                {
                    { 1, "cc2bfa35-7ac9-45cd-96e2-0c815b1646f0", 1, "пилешки гърди - 2 бр.\r\nайсберг\r\nчери домати - около 200 г\r\nкраставици - 1 бр.\r\nмайонеза - 3 с.л.\r\nкисело мляко - 3 с.л.\r\nчерен пипер\r\nчервен пипер\r\nсол\r\nлимонов сок\r\nзехтин\r\nкрутони\r\nпармезан\r\nПилешките гърди се овкусяват със сол и черен пипер и се изпичат на скара /или оребрен тиган/. След като изстинат се нарязват на хапки.\r\n\r\nСалатата се почиства, измива се и се накъсва. Прибавят се нарязаните краставица и чери доматки.\r\n\r\nДобавят се пилешките късчета и крутоните.\r\n\r\nВ отделен съд се смесват киселото мляко, майонезата и лимоновия сок. Овкусява се с черен и червен пипер и сол.\r\n\r\nС готовия сос се овкусява салатата Цезар. Най-отгоре се настъргва пармезан.\r\n\r\n", "https://recepti.gotvach.bg/files/lib/600x350/salatacesarpile.webp", true, null, "Салата Цезар" },
                    { 2, "c61a4d9b-6baa-408f-8a14-4b54694ab219", 4, "Необходими продукти:\r\n\r\n150 г суров нахут (1 консерва нахут – 400 г)\r\n\r\nсол на вкус\r\n\r\n2 ч. л. чубрица\r\n\r\n1/2 ч. л. джоджен\r\n\r\nщипка черен пипер\r\n\r\nщипка кимион\r\n\r\n1/2 малка глава кр. лук\r\n\r\n2 скилидки чесън\r\n\r\n1/4 връзка магданоз\r\n\r\n1 яйце\r\n\r\n2 с. л. зехтин\r\n\r\n \r\n\r\nНачин на приготвяне:\r\n\r\nСледвайки твърдения на експертите по хранене накисваме нахута за 18-24 часа в топла вода. Водата от накисването се изхвърля. При възможност е желателно да сменяме водата на около 8 часа, за да я поддържаме топла. Когато наливаме вода е необходимо не само да покрием нахута, а да оставим 5-10 см вода за набъбване.\r\n\r\nСваряваме нахута и го прецеждаме. Поставяме го в кухненския робот (ако нямате използвайте ръчна преса или пасатор). Подправяме на вкус с всички подправки, като лука и чесъна наситняваме с нож. Пасираме докато получим паста. Ако сместта е суха при пасиране може да добавим малко вода.\r\n\r\nС ръце или с две лъжици се оформят кюфтета, овъргалят се в брашно (царевично, нахутено, бяло и др.) и се пържат от двете страни докато станат златисти.", "https://azgotvia.eu/wp-content/uploads/2015/03/DSC_0081-1-770x460.jpg", true, null, "Нахутени кюфтета" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
