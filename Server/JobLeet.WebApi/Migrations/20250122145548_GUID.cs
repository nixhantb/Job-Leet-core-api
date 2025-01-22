using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobLeet.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class GUID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Status",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
            );

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "jblt_userAddress",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
            );

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "jblt_skill",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
            );

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "jblt_seeker",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
            );

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "jblt_qualification",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
            );

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "jblt_phone",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
            );

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "jblt_personName",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
            );

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "jblt_job",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
            );

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "jblt_industryType",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
            );

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "jblt_experience",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
            );

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "jblt_employer",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
            );

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "jblt_education",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
            );

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "jblt_companyprofile",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
            );

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "jblt_company",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
            );

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "jblt_application",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
            );

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Emails",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
            );

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "ApplicationDate",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "CreatedOn", table: "Status");

            migrationBuilder.DropColumn(name: "CreatedOn", table: "jblt_userAddress");

            migrationBuilder.DropColumn(name: "CreatedOn", table: "jblt_skill");

            migrationBuilder.DropColumn(name: "CreatedOn", table: "jblt_seeker");

            migrationBuilder.DropColumn(name: "CreatedOn", table: "jblt_qualification");

            migrationBuilder.DropColumn(name: "CreatedOn", table: "jblt_phone");

            migrationBuilder.DropColumn(name: "CreatedOn", table: "jblt_personName");

            migrationBuilder.DropColumn(name: "CreatedOn", table: "jblt_job");

            migrationBuilder.DropColumn(name: "CreatedOn", table: "jblt_industryType");

            migrationBuilder.DropColumn(name: "CreatedOn", table: "jblt_experience");

            migrationBuilder.DropColumn(name: "CreatedOn", table: "jblt_employer");

            migrationBuilder.DropColumn(name: "CreatedOn", table: "jblt_education");

            migrationBuilder.DropColumn(name: "CreatedOn", table: "jblt_companyprofile");

            migrationBuilder.DropColumn(name: "CreatedOn", table: "jblt_company");

            migrationBuilder.DropColumn(name: "CreatedOn", table: "jblt_application");

            migrationBuilder.DropColumn(name: "CreatedOn", table: "Emails");

            migrationBuilder.DropColumn(name: "CreatedOn", table: "ApplicationDate");
        }
    }
}
