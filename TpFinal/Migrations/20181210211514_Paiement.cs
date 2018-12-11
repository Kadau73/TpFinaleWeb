using Microsoft.EntityFrameworkCore.Migrations;

namespace TpFinal.Migrations
{
    public partial class Paiement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VersionArticle",
                table: "VersionArticle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Session",
                table: "Session");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Paiement",
                table: "Paiement");

            migrationBuilder.RenameTable(
                name: "VersionArticle",
                newName: "VersionArticles");

            migrationBuilder.RenameTable(
                name: "Session",
                newName: "Sessions");

            migrationBuilder.RenameTable(
                name: "Paiement",
                newName: "Paiements");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VersionArticles",
                table: "VersionArticles",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sessions",
                table: "Sessions",
                column: "ArticleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Paiements",
                table: "Paiements",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VersionArticles",
                table: "VersionArticles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sessions",
                table: "Sessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Paiements",
                table: "Paiements");

            migrationBuilder.RenameTable(
                name: "VersionArticles",
                newName: "VersionArticle");

            migrationBuilder.RenameTable(
                name: "Sessions",
                newName: "Session");

            migrationBuilder.RenameTable(
                name: "Paiements",
                newName: "Paiement");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VersionArticle",
                table: "VersionArticle",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Session",
                table: "Session",
                column: "ArticleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Paiement",
                table: "Paiement",
                column: "ID");
        }
    }
}
