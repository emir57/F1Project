using Microsoft.EntityFrameworkCore.Migrations;

namespace f1project.data.Migrations
{
    public partial class ColumnNameUpdateByID4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostDriver_Drivers_PdDriverId",
                table: "PostDriver");

            migrationBuilder.DropForeignKey(
                name: "FK_PostDriver_Posts_PdPostId",
                table: "PostDriver");

            migrationBuilder.DropForeignKey(
                name: "FK_PostTeam_Posts_PtPostId",
                table: "PostTeam");

            migrationBuilder.DropForeignKey(
                name: "FK_PostTeam_Teams_PtTeamId",
                table: "PostTeam");

            migrationBuilder.RenameColumn(
                name: "PtPostId",
                table: "PostTeam",
                newName: "PostId");

            migrationBuilder.RenameColumn(
                name: "PtTeamId",
                table: "PostTeam",
                newName: "TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_PostTeam_PtPostId",
                table: "PostTeam",
                newName: "IX_PostTeam_PostId");

            migrationBuilder.RenameColumn(
                name: "PdPostId",
                table: "PostDriver",
                newName: "PostId");

            migrationBuilder.RenameColumn(
                name: "PdDriverId",
                table: "PostDriver",
                newName: "DriverId");

            migrationBuilder.RenameIndex(
                name: "IX_PostDriver_PdPostId",
                table: "PostDriver",
                newName: "IX_PostDriver_PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostDriver_Drivers_DriverId",
                table: "PostDriver",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "DriverId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostDriver_Posts_PostId",
                table: "PostDriver",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "PostId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostTeam_Posts_PostId",
                table: "PostTeam",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "PostId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostTeam_Teams_TeamId",
                table: "PostTeam",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostDriver_Drivers_DriverId",
                table: "PostDriver");

            migrationBuilder.DropForeignKey(
                name: "FK_PostDriver_Posts_PostId",
                table: "PostDriver");

            migrationBuilder.DropForeignKey(
                name: "FK_PostTeam_Posts_PostId",
                table: "PostTeam");

            migrationBuilder.DropForeignKey(
                name: "FK_PostTeam_Teams_TeamId",
                table: "PostTeam");

            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "PostTeam",
                newName: "PtPostId");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "PostTeam",
                newName: "PtTeamId");

            migrationBuilder.RenameIndex(
                name: "IX_PostTeam_PostId",
                table: "PostTeam",
                newName: "IX_PostTeam_PtPostId");

            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "PostDriver",
                newName: "PdPostId");

            migrationBuilder.RenameColumn(
                name: "DriverId",
                table: "PostDriver",
                newName: "PdDriverId");

            migrationBuilder.RenameIndex(
                name: "IX_PostDriver_PostId",
                table: "PostDriver",
                newName: "IX_PostDriver_PdPostId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostDriver_Drivers_PdDriverId",
                table: "PostDriver",
                column: "PdDriverId",
                principalTable: "Drivers",
                principalColumn: "DriverId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostDriver_Posts_PdPostId",
                table: "PostDriver",
                column: "PdPostId",
                principalTable: "Posts",
                principalColumn: "PostId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostTeam_Posts_PtPostId",
                table: "PostTeam",
                column: "PtPostId",
                principalTable: "Posts",
                principalColumn: "PostId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostTeam_Teams_PtTeamId",
                table: "PostTeam",
                column: "PtTeamId",
                principalTable: "Teams",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
