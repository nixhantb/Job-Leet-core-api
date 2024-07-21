using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobLeet.WebApi.Migrations
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
                name: "jblt_education",
                columns: table => new
                {
                    educationid = table.Column<int>(name: "education_id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    educationdegree = table.Column<string>(name: "education_degree", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    educationmajor = table.Column<string>(name: "education_major", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    educationnstitution = table.Column<string>(name: "education_nstitution", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    educationgraduationdate = table.Column<DateOnly>(name: "education_graduationdate", type: "date", nullable: false),
                    educationcgpa = table.Column<decimal>(name: "education_cgpa", type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jblt_education", x => x.educationid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "jblt_email",
                columns: table => new
                {
                    emailid = table.Column<int>(name: "email_id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    emailtype = table.Column<int>(name: "email_type", type: "int", nullable: false),
                    emailaddress = table.Column<string>(name: "email_address", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jblt_email", x => x.emailid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "jblt_experience",
                columns: table => new
                {
                    experienceid = table.Column<int>(name: "experience_id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    experiencetype = table.Column<int>(name: "experience_type", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jblt_experience", x => x.experienceid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "jblt_personName",
                columns: table => new
                {
                    personnameid = table.Column<int>(name: "personname_id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    personNamefirstname = table.Column<string>(name: "personName_firstname", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    personNamemiddlename = table.Column<string>(name: "personName_middlename", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    personNamelastname = table.Column<string>(name: "personName_lastname", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jblt_personName", x => x.personnameid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "jblt_phone",
                columns: table => new
                {
                    jbltphoneid = table.Column<int>(name: "jblt_phoneid", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    jbltcountrycode = table.Column<int>(name: "jblt_countrycode", type: "int", nullable: false),
                    jbltphonenumber = table.Column<string>(name: "jblt_phonenumber", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jblt_phone", x => x.jbltphoneid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "jblt_qualification",
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
                    table.PrimaryKey("PK_jblt_qualification", x => x.qualificationid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "jblt_role",
                columns: table => new
                {
                    roleroleid = table.Column<int>(name: "role_roleid", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    rolename = table.Column<int>(name: "role_name", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jblt_role", x => x.roleroleid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "jblt_skill",
                columns: table => new
                {
                    skillid = table.Column<int>(name: "skill_id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jblt_skill", x => x.skillid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "jblt_userAddress",
                columns: table => new
                {
                    addressid = table.Column<int>(name: "address_id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    addressstreet = table.Column<string>(name: "address_street", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    addresscity = table.Column<string>(name: "address_city", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    addressstate = table.Column<string>(name: "address_state", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    addresspostalCode = table.Column<string>(name: "address_postalCode", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    addresscountry = table.Column<string>(name: "address_country", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jblt_userAddress", x => x.addressid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "jblt_loginuser",
                columns: table => new
                {
                    loginuserid = table.Column<int>(name: "loginuser_id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    loginuseraddress = table.Column<string>(name: "loginuser_address", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    loginuserpassword = table.Column<string>(name: "loginuser_password", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PersonNameId = table.Column<int>(type: "int", nullable: true),
                    loginuseraccountstatus = table.Column<int>(name: "loginuser_accountstatus", type: "int", nullable: false),
                    loginuseraccountcreated = table.Column<bool>(name: "loginuser_accountcreated", type: "tinyint(1)", nullable: false),
                    loginuserlogintime = table.Column<DateTime>(name: "loginuser_logintime", type: "datetime(6)", nullable: false),
                    loginuseripaddress = table.Column<string>(name: "loginuser_ipaddress", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    loginuserrole = table.Column<int>(name: "loginuser_role", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jblt_loginuser", x => x.loginuserid);
                    table.ForeignKey(
                        name: "FK_jblt_loginuser_jblt_personName_PersonNameId",
                        column: x => x.PersonNameId,
                        principalTable: "jblt_personName",
                        principalColumn: "personname_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "jblt_registerUser",
                columns: table => new
                {
                    jbltregisterid = table.Column<int>(name: "jblt_registerid", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Salt = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PersonNameId = table.Column<int>(type: "int", nullable: false),
                    UserEmailId = table.Column<int>(type: "int", nullable: false),
                    jbltpassword = table.Column<string>(name: "jblt_password", type: "varchar(101)", maxLength: 101, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    jbltconfirmpassword = table.Column<string>(name: "jblt_confirmpassword", type: "varchar(101)", maxLength: 101, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jblt_registerUser", x => x.jbltregisterid);
                    table.ForeignKey(
                        name: "FK_jblt_registerUser_jblt_email_UserEmailId",
                        column: x => x.UserEmailId,
                        principalTable: "jblt_email",
                        principalColumn: "email_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_jblt_registerUser_jblt_personName_PersonNameId",
                        column: x => x.PersonNameId,
                        principalTable: "jblt_personName",
                        principalColumn: "personname_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "jblt_companyprofile",
                columns: table => new
                {
                    companyprofileid = table.Column<int>(name: "companyprofile_id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProfileInfo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CompanyAddressId = table.Column<int>(type: "int", nullable: true),
                    ContactPhoneId = table.Column<int>(type: "int", nullable: true),
                    ContactEmailId = table.Column<int>(type: "int", nullable: true),
                    companywebsite = table.Column<string>(name: "company_website", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IndustryType = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jblt_companyprofile", x => x.companyprofileid);
                    table.ForeignKey(
                        name: "FK_jblt_companyprofile_jblt_email_ContactEmailId",
                        column: x => x.ContactEmailId,
                        principalTable: "jblt_email",
                        principalColumn: "email_id");
                    table.ForeignKey(
                        name: "FK_jblt_companyprofile_jblt_phone_ContactPhoneId",
                        column: x => x.ContactPhoneId,
                        principalTable: "jblt_phone",
                        principalColumn: "jblt_phoneid");
                    table.ForeignKey(
                        name: "FK_jblt_companyprofile_jblt_userAddress_CompanyAddressId",
                        column: x => x.CompanyAddressId,
                        principalTable: "jblt_userAddress",
                        principalColumn: "address_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "jblt_company",
                columns: table => new
                {
                    companyid = table.Column<int>(name: "company_id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    companyname = table.Column<string>(name: "company_name", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProfileId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jblt_company", x => x.companyid);
                    table.ForeignKey(
                        name: "FK_jblt_company_jblt_companyprofile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "jblt_companyprofile",
                        principalColumn: "companyprofile_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "jblt_job",
                columns: table => new
                {
                    jobid = table.Column<int>(name: "job_id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CompanyDescriptionId = table.Column<int>(type: "int", nullable: true),
                    jobtitle = table.Column<string>(name: "job_title", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    jobdescription = table.Column<string>(name: "job_description", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    jobtype = table.Column<string>(name: "job_type", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    JobAddressId = table.Column<int>(type: "int", nullable: true),
                    jobvacancies = table.Column<int>(name: "job_vacancies", type: "int", nullable: true),
                    jobbasicpay = table.Column<string>(name: "job_basic_pay", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    jobfunctionalarea = table.Column<string>(name: "job_functional_area", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SkillsRequiredId = table.Column<int>(type: "int", nullable: true),
                    RequiredQualificationId = table.Column<int>(type: "int", nullable: true),
                    RequiredExperienceId = table.Column<int>(type: "int", nullable: true),
                    preferredqualifications = table.Column<string>(name: "preferred_qualifications", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    jobresponsibility = table.Column<string>(name: "job_responsibility", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    jobbenefits = table.Column<string>(name: "job_benefits", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    jobtags = table.Column<string>(name: "job_tags", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    jobworkenvironment = table.Column<string>(name: "job_workenvironment", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    jobpostingdate = table.Column<DateTime>(name: "job_posting_date", type: "datetime(6)", nullable: true),
                    jobapplicationdeadline = table.Column<DateTime>(name: "job_applicationdeadline", type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jblt_job", x => x.jobid);
                    table.ForeignKey(
                        name: "FK_jblt_job_jblt_company_CompanyDescriptionId",
                        column: x => x.CompanyDescriptionId,
                        principalTable: "jblt_company",
                        principalColumn: "company_id");
                    table.ForeignKey(
                        name: "FK_jblt_job_jblt_experience_RequiredExperienceId",
                        column: x => x.RequiredExperienceId,
                        principalTable: "jblt_experience",
                        principalColumn: "experience_id");
                    table.ForeignKey(
                        name: "FK_jblt_job_jblt_qualification_RequiredQualificationId",
                        column: x => x.RequiredQualificationId,
                        principalTable: "jblt_qualification",
                        principalColumn: "qualification_id");
                    table.ForeignKey(
                        name: "FK_jblt_job_jblt_skill_SkillsRequiredId",
                        column: x => x.SkillsRequiredId,
                        principalTable: "jblt_skill",
                        principalColumn: "skill_id");
                    table.ForeignKey(
                        name: "FK_jblt_job_jblt_userAddress_JobAddressId",
                        column: x => x.JobAddressId,
                        principalTable: "jblt_userAddress",
                        principalColumn: "address_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_jblt_company_ProfileId",
                table: "jblt_company",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_jblt_companyprofile_CompanyAddressId",
                table: "jblt_companyprofile",
                column: "CompanyAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_jblt_companyprofile_ContactEmailId",
                table: "jblt_companyprofile",
                column: "ContactEmailId");

            migrationBuilder.CreateIndex(
                name: "IX_jblt_companyprofile_ContactPhoneId",
                table: "jblt_companyprofile",
                column: "ContactPhoneId");

            migrationBuilder.CreateIndex(
                name: "IX_jblt_job_CompanyDescriptionId",
                table: "jblt_job",
                column: "CompanyDescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_jblt_job_JobAddressId",
                table: "jblt_job",
                column: "JobAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_jblt_job_RequiredExperienceId",
                table: "jblt_job",
                column: "RequiredExperienceId");

            migrationBuilder.CreateIndex(
                name: "IX_jblt_job_RequiredQualificationId",
                table: "jblt_job",
                column: "RequiredQualificationId");

            migrationBuilder.CreateIndex(
                name: "IX_jblt_job_SkillsRequiredId",
                table: "jblt_job",
                column: "SkillsRequiredId");

            migrationBuilder.CreateIndex(
                name: "IX_jblt_loginuser_PersonNameId",
                table: "jblt_loginuser",
                column: "PersonNameId");

            migrationBuilder.CreateIndex(
                name: "IX_jblt_registerUser_PersonNameId",
                table: "jblt_registerUser",
                column: "PersonNameId");

            migrationBuilder.CreateIndex(
                name: "IX_jblt_registerUser_UserEmailId",
                table: "jblt_registerUser",
                column: "UserEmailId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "jblt_education");

            migrationBuilder.DropTable(
                name: "jblt_job");

            migrationBuilder.DropTable(
                name: "jblt_loginuser");

            migrationBuilder.DropTable(
                name: "jblt_registerUser");

            migrationBuilder.DropTable(
                name: "jblt_role");

            migrationBuilder.DropTable(
                name: "jblt_company");

            migrationBuilder.DropTable(
                name: "jblt_experience");

            migrationBuilder.DropTable(
                name: "jblt_qualification");

            migrationBuilder.DropTable(
                name: "jblt_skill");

            migrationBuilder.DropTable(
                name: "jblt_personName");

            migrationBuilder.DropTable(
                name: "jblt_companyprofile");

            migrationBuilder.DropTable(
                name: "jblt_email");

            migrationBuilder.DropTable(
                name: "jblt_phone");

            migrationBuilder.DropTable(
                name: "jblt_userAddress");
        }
    }
}
