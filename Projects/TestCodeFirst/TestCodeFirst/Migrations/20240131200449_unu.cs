﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class unu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Elevi",
                columns: table => new
                {
                    ElevID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Varsta = table.Column<int>(type: "int", nullable: false),
                    DataNasterii = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elevi", x => x.ElevID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Elevi");
        }
    }
}
