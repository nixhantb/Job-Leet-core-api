using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobLeet.WebApi.JobLeet.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Street = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    State = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PostalCode = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    educationid = table.Column<int>(name: "education_id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    degree = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    major = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    institution = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    graduationdate = table.Column<DateOnly>(name: "graduation_date", type: "date", nullable: false),
                    cgpa = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.educationid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Email",
                columns: table => new
                {
                    emailid = table.Column<int>(name: "email_id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    emailtype = table.Column<int>(name: "email_type", type: "int", nullable: false),
                    emailaddress = table.Column<string>(name: "email_address", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email", x => x.emailid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Experience",
                columns: table => new
                {
                    experienceid = table.Column<int>(name: "experience_id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    experiencetype = table.Column<int>(name: "experience_type", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experience", x => x.experienceid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PersonName",
                columns: table => new
                {
                    personnameid = table.Column<int>(name: "personname_id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    firstname = table.Column<string>(name: "first_name", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    middlename = table.Column<string>(name: "middle_name", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    lastname = table.Column<string>(name: "last_name", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonName", x => x.personnameid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Phone",
                columns: table => new
                {
                    phoneid = table.Column<int>(name: "phone_id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    countrycode = table.Column<int>(name: "country_code", type: "int", nullable: false),
                    phonenumber = table.Column<string>(name: "phone_number", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phone", x => x.phoneid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Qualification",
                columns: table => new
                {
                    qualificationid = table.Column<int>(name: "qualification_id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    qualificationtype = table.Column<int>(name: "qualification_type", type: "int", nullable: false),
                    qualificationinformation = table.Column<string>(name: "qualification_information", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualification", x => x.qualificationid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SkillModel",
                columns: table => new
                {
                    skillid = table.Column<int>(name: "skill_id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    skilltitle = table.Column<string>(name: "skill_title", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    skilldescription = table.Column<string>(name: "skill_description", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillModel", x => x.skillid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "Email");

            migrationBuilder.DropTable(
                name: "Experience");

            migrationBuilder.DropTable(
                name: "PersonName");

            migrationBuilder.DropTable(
                name: "Phone");

            migrationBuilder.DropTable(
                name: "Qualification");

            migrationBuilder.DropTable(
                name: "SkillModel");
        }
    }
}
