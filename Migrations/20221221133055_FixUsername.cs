using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PracticaNET2.Migrations
{
    /// <inheritdoc />
    public partial class FixUsername : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Usuario",
                table: "People",
                newName: "Username");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "People",
                newName: "Usuario");
        }
    }
}
