using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Amana_Api.Migrations
{
    /// <inheritdoc />
    public partial class DueDateToUnixTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "DueDate",
                table: "Task",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "TEXT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "DueDate",
                table: "Task",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER");
        }
    }
}
