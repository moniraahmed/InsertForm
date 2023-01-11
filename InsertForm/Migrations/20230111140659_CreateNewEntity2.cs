using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsertForm.Migrations
{
    /// <inheritdoc />
    public partial class CreateNewEntity2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "UserForm");

            migrationBuilder.RenameColumn(
                name: "File",
                table: "UserForm",
                newName: "DateOfBirth");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "UserForm",
                newName: "File");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "UserForm",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
