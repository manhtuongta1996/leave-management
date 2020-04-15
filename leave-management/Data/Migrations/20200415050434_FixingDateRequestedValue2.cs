using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace leave_management.Data.Migrations
{
    public partial class FixingDateRequestedValue2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataRequested",
                table: "LeaveRequests");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateRequested",
                table: "LeaveRequests",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateRequested",
                table: "LeaveRequests");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataRequested",
                table: "LeaveRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
