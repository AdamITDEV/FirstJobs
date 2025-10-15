// Migrations/20251015_Add_Phones.cs
using Microsoft.EntityFrameworkCore.Migrations;
using System;

public partial class Add_Phones : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Phones",
            columns: table => new
            {
                Id = table.Column<int>().Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(maxLength: 256, nullable: false),
                Brand = table.Column<string>(maxLength: 128, nullable: false),
                Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                Stock = table.Column<int>(nullable: false),
                ImageUrl = table.Column<string>(maxLength: 512, nullable: true),
                CreationTime = table.Column<DateTime>(nullable: false),
                CreatorUserId = table.Column<long>(nullable: true),
                LastModificationTime = table.Column<DateTime>(nullable: true),
                LastModifierUserId = table.Column<long>(nullable: true),
                IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                DeleterUserId = table.Column<long>(nullable: true),
                DeletionTime = table.Column<DateTime>(nullable: true)
            },
            constraints: table => { table.PrimaryKey("PK_Phones", x => x.Id); }
        );
    }
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(name: "Phones");
    }
}
