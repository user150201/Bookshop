﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingCart1.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedstatuscodeinorderstatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Orderstatus",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Orderstatus");
        }
    }
}
