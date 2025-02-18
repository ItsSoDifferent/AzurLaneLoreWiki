using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AzurLaneLoreWiki.Migrations
{
    /// <inheritdoc />
    public partial class addingEventCharacterMapping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventCharacterMappings",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "INTEGER", nullable: false),
                    CharacterId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventCharacterMappings");
        }
    }
}
