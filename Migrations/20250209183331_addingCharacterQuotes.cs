using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AzurLaneLoreWiki.Migrations
{
    /// <inheritdoc />
    public partial class addingCharacterQuotes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CharacterQuotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CharacterId = table.Column<int>(type: "INTEGER", nullable: false),
                    EventId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quote = table.Column<string>(type: "TEXT", nullable: false),
                    QuoteEventIndex = table.Column<int>(type: "INTEGER", nullable: false),
                    QuoteConversationId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterQuotes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterQuotes");
        }
    }
}
