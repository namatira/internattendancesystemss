﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AttendanceSytstemWebApplication.Migrations
{
    public partial class ChgStuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Day",
                table: "Schedule");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Schedule",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Schedule");

            migrationBuilder.AddColumn<DateTime>(
                name: "Day",
                table: "Schedule",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
