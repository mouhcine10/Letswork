using Microsoft.EntityFrameworkCore.Migrations;

namespace APILETSWORK.Migrations
{
    public partial class ajoutdeslien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProIdPro",
                table: "missions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MissionIDmission",
                table: "categories",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_missions_ProIdPro",
                table: "missions",
                column: "ProIdPro");

            migrationBuilder.CreateIndex(
                name: "IX_categories_MissionIDmission",
                table: "categories",
                column: "MissionIDmission");

            migrationBuilder.AddForeignKey(
                name: "FK_categories_missions_MissionIDmission",
                table: "categories",
                column: "MissionIDmission",
                principalTable: "missions",
                principalColumn: "IDmission",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_missions_pros_ProIdPro",
                table: "missions",
                column: "ProIdPro",
                principalTable: "pros",
                principalColumn: "IdPro",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_categories_missions_MissionIDmission",
                table: "categories");

            migrationBuilder.DropForeignKey(
                name: "FK_missions_pros_ProIdPro",
                table: "missions");

            migrationBuilder.DropIndex(
                name: "IX_missions_ProIdPro",
                table: "missions");

            migrationBuilder.DropIndex(
                name: "IX_categories_MissionIDmission",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "ProIdPro",
                table: "missions");

            migrationBuilder.DropColumn(
                name: "MissionIDmission",
                table: "categories");
        }
    }
}
