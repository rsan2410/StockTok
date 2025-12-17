using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace News.Migrations
{
    /// <inheritdoc />
    public partial class ColumnNaming : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "News");

            migrationBuilder.RenameTable(
                name: "NewsArticles",
                newName: "NewsArticles",
                newSchema: "News");

            migrationBuilder.RenameTable(
                name: "NewsArticleEntities",
                newName: "NewsArticleEntities",
                newSchema: "News");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "NewsArticles",
                schema: "News",
                newName: "NewsArticles");

            migrationBuilder.RenameTable(
                name: "NewsArticleEntities",
                schema: "News",
                newName: "NewsArticleEntities");
        }
    }
}
