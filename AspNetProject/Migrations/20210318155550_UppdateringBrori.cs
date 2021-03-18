using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetProject.Migrations
{
    public partial class UppdateringBrori : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AttendeeEvent",
                columns: table => new
                {
                    AttendeesID = table.Column<int>(type: "int", nullable: false),
                    EventsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendeeEvent", x => new { x.AttendeesID, x.EventsID });
                    table.ForeignKey(
                        name: "FK_AttendeeEvent_Attendee_AttendeesID",
                        column: x => x.AttendeesID,
                        principalTable: "Attendee",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttendeeEvent_Event_EventsID",
                        column: x => x.EventsID,
                        principalTable: "Event",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttendeeEvent_EventsID",
                table: "AttendeeEvent",
                column: "EventsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttendeeEvent");
        }
    }
}
