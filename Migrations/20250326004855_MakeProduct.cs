using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiCoffeeShop.Migrations
{
    /// <inheritdoc />
    public partial class MakeProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Products(ProductName, ProductImageUrl, ProductDescription, ProductPrice, CategoryId)" +
                "VALUES('Italian Cappuccino', 'ItalianCappuccino.jpg', 'A traditional italian cappuccino, with milk and foam. 220ml', 7.99, 1)");

            mb.Sql("INSERT INTO Products(ProductName, ProductImageUrl, ProductDescription, ProductPrice, CategoryId)" +
               "VALUES('Espresso', 'espresso.jpg', 'Strong espresso. 50ml', 3.99, 1)");

            mb.Sql("INSERT INTO Products(ProductName, ProductImageUrl, ProductDescription, ProductPrice, CategoryId)" +
               "VALUES('Mocha Coffee', 'mocha.jpg', 'Espress, milk and chocolate together. 380ml', 7.99, 1)");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Products");

        }
    }
}
