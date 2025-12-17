using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace News.Migrations
{
    /// <inheritdoc />
    public partial class change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NewsArticleEntities_NewsArticles_NewsArticleId",
                schema: "News",
                table: "NewsArticleEntities");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "News",
                table: "NewsArticleEntities",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "NewsArticleId",
                schema: "News",
                table: "NewsArticleEntities",
                newName: "ArticleID");

            migrationBuilder.RenameIndex(
                name: "IX_NewsArticleEntities_NewsArticleId",
                schema: "News",
                table: "NewsArticleEntities",
                newName: "IX_NewsArticleEntities_ArticleID");

            migrationBuilder.AddForeignKey(
                name: "FK_NewsArticleEntities_NewsArticles_ArticleID",
                schema: "News",
                table: "NewsArticleEntities",
                column: "ArticleID",
                principalSchema: "News",
                principalTable: "NewsArticles",
                principalColumn: "Uuid",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NewsArticleEntities_NewsArticles_ArticleID",
                schema: "News",
                table: "NewsArticleEntities");

            migrationBuilder.RenameColumn(
                name: "ID",
                schema: "News",
                table: "NewsArticleEntities",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ArticleID",
                schema: "News",
                table: "NewsArticleEntities",
                newName: "NewsArticleId");

            migrationBuilder.RenameIndex(
                name: "IX_NewsArticleEntities_ArticleID",
                schema: "News",
                table: "NewsArticleEntities",
                newName: "IX_NewsArticleEntities_NewsArticleId");

            migrationBuilder.AddForeignKey(
                name: "FK_NewsArticleEntities_NewsArticles_NewsArticleId",
                schema: "News",
                table: "NewsArticleEntities",
                column: "NewsArticleId",
                principalSchema: "News",
                principalTable: "NewsArticles",
                principalColumn: "Uuid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
