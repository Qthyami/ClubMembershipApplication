using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClubMembershipApplication.Migrations
{
    /// <inheritdoc />
    public partial class AddEmailAddresToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AdressSecondLine",
                table: "Users",
                newName: "PostCode");

            migrationBuilder.RenameColumn(
                name: "AdressFirstLine",
                table: "Users",
                newName: "EmailAddress");

            migrationBuilder.RenameColumn(
                name: "AdressCity",
                table: "Users",
                newName: "AddressSecondLine");

            migrationBuilder.AddColumn<string>(
                name: "AddressCity",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AddressFirstLine",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressCity",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AddressFirstLine",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "PostCode",
                table: "Users",
                newName: "AdressSecondLine");

            migrationBuilder.RenameColumn(
                name: "EmailAddress",
                table: "Users",
                newName: "AdressFirstLine");

            migrationBuilder.RenameColumn(
                name: "AddressSecondLine",
                table: "Users",
                newName: "AdressCity");
        }
    }
}
