using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobLeet.WebApi.Migrations.BaseDB
{
    /// <inheritdoc />
    public partial class BaseDBCreate2095 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "SocialMedia", table: "jblt_seeker");

            migrationBuilder.CreateTable(
                name: "SocialMedia",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Url = table.Column<string>(type: "text", nullable: true),
                    SeekerId = table.Column<string>(type: "text", nullable: true),
                    CreatedOn = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: false
                    ),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SocialMedia_jblt_seeker_SeekerId",
                        column: x => x.SeekerId,
                        principalTable: "jblt_seeker",
                        principalColumn: "seeker_id"
                    );
                }
            );

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedia_SeekerId",
                table: "SocialMedia",
                column: "SeekerId"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "SocialMedia");

            migrationBuilder.AddColumn<List<string>>(
                name: "SocialMedia",
                table: "jblt_seeker",
                type: "text[]",
                nullable: false
            );
        }
    }
}
