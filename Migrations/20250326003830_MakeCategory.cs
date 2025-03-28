using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiCoffeeShop.Migrations
{
    /// <inheritdoc />
    public partial class MakeCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Categories(CategoryName,CategoryDescription,CategoryImageUrl)VALUES('Coffee','Coffees','coffee.jpg')");
            mb.Sql("INSERT INTO Categories(CategoryName,CategoryDescription,CategoryImageUrl)VALUES('Bakery Products','Bakery','bakery.jpg')");
            mb.Sql("INSERT INTO Categories(CategoryName,CategoryDescription,CategoryImageUrl)VALUES('Juice','Juices','juice.jpg')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Categories");
        }
    }
}
