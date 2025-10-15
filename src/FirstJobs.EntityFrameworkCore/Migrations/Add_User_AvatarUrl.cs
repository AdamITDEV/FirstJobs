// Migrations/Add_User_AvatarUrl.cs
using Microsoft.EntityFrameworkCore.Migrations;

public partial class Add_User_AvatarUrl : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<string>(
            name: "AvatarUrl",
            table: "AbpUsers",
            type: "nvarchar(512)",
            maxLength: 512,
            nullable: true);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(name: "AvatarUrl", table: "AbpUsers");
    }
}
