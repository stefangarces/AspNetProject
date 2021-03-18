using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetProject.Migrations
{
    public partial class EyDeHanJu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Organizer_OrgIDID",
                table: "Event");

            migrationBuilder.RenameColumn(
                name: "OrgIDID",
                table: "Event",
                newName: "OrganizerID");

            migrationBuilder.RenameIndex(
                name: "IX_Event_OrgIDID",
                table: "Event",
                newName: "IX_Event_OrganizerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Organizer_OrganizerID",
                table: "Event",
                column: "OrganizerID",
                principalTable: "Organizer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Organizer_OrganizerID",
                table: "Event");

            migrationBuilder.RenameColumn(
                name: "OrganizerID",
                table: "Event",
                newName: "OrgIDID");

            migrationBuilder.RenameIndex(
                name: "IX_Event_OrganizerID",
                table: "Event",
                newName: "IX_Event_OrgIDID");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Organizer_OrgIDID",
                table: "Event",
                column: "OrgIDID",
                principalTable: "Organizer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
