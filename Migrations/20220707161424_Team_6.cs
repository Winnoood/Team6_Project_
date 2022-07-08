using Microsoft.EntityFrameworkCore.Migrations;

namespace Team6_Project_.Migrations
{
    public partial class Team_6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRegister",
                table: "UserRegister");

            migrationBuilder.RenameTable(
                name: "UserRegister",
                newName: "Employee");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "UserRegister");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRegister",
                table: "UserRegister",
                column: "Id");
        }
    }
}
