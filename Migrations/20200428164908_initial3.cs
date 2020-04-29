using Microsoft.EntityFrameworkCore.Migrations;

namespace BeltExam.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DojoActivities_DojoActivities_DojoActivityId1",
                table: "DojoActivities");

            migrationBuilder.DropIndex(
                name: "IX_DojoActivities_DojoActivityId1",
                table: "DojoActivities");

            migrationBuilder.DropColumn(
                name: "DojoActivityId1",
                table: "DojoActivities");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DojoActivityId1",
                table: "DojoActivities",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DojoActivities_DojoActivityId1",
                table: "DojoActivities",
                column: "DojoActivityId1");

            migrationBuilder.AddForeignKey(
                name: "FK_DojoActivities_DojoActivities_DojoActivityId1",
                table: "DojoActivities",
                column: "DojoActivityId1",
                principalTable: "DojoActivities",
                principalColumn: "DojoActivityId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
