using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobLeet.WebApi.Migrations.BaseDB
{
    /// <inheritdoc />
    public partial class BaseDBCreate2589 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProjectsId",
                table: "jblt_seeker",
                type: "text",
                nullable: true
            );

            migrationBuilder.AddColumn<DateTime>(
                name: "ExperienceDateFrom",
                table: "jblt_experience",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
            );

            migrationBuilder.AddColumn<DateTime>(
                name: "ExperienceDateTill",
                table: "jblt_experience",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
            );

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Responsibilities = table.Column<List<string>>(type: "text[]", nullable: false),
                    TechnologiesUsed = table.Column<List<string>>(type: "text[]", nullable: false),
                    Role = table.Column<string>(type: "text", nullable: true),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    ProjectUrl = table.Column<string>(type: "text", nullable: true),
                    GitHubUrl = table.Column<string>(type: "text", nullable: true),
                    CreatedOn = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: false
                    ),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                }
            );

            migrationBuilder.CreateIndex(
                name: "IX_jblt_seeker_ProjectsId",
                table: "jblt_seeker",
                column: "ProjectsId"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_jblt_seeker_Project_ProjectsId",
                table: "jblt_seeker",
                column: "ProjectsId",
                principalTable: "Project",
                principalColumn: "Id"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_jblt_seeker_Project_ProjectsId",
                table: "jblt_seeker"
            );

            migrationBuilder.DropTable(name: "Project");

            migrationBuilder.DropIndex(name: "IX_jblt_seeker_ProjectsId", table: "jblt_seeker");

            migrationBuilder.DropColumn(name: "ProjectsId", table: "jblt_seeker");

            migrationBuilder.DropColumn(name: "ExperienceDateFrom", table: "jblt_experience");

            migrationBuilder.DropColumn(name: "ExperienceDateTill", table: "jblt_experience");
        }
    }
}
