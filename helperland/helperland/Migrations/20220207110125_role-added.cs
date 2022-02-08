﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace helperland.Migrations
{
    public partial class roleadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "roleId",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "roleId",
                table: "User");
        }
    }
}
