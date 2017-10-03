using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HealthTracker.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BehaviorActivity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Breakfast = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dinner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Drank = table.Column<bool>(type: "bit", nullable: false),
                    ExerciseBehaviors = table.Column<bool>(type: "bit", nullable: false),
                    Lunch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sexed = table.Column<bool>(type: "bit", nullable: false),
                    Smoked = table.Column<bool>(type: "bit", nullable: false),
                    Snacks = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormDatas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormDatas");
        }
    }
}
