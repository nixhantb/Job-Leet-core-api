using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace JobLeet.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "jblt_education",
                columns: table => new
                {
                    educationid = table.Column<int>(name: "education_id", type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    educationdegree = table.Column<string>(name: "education_degree", type: "text", nullable: false),
                    educationmajor = table.Column<string>(name: "education_major", type: "text", nullable: false),
                    educationnstitution = table.Column<string>(name: "education_nstitution", type: "text", nullable: false),
                    educationgraduationdate = table.Column<DateOnly>(name: "education_graduationdate", type: "date", nullable: false),
                    educationcgpa = table.Column<decimal>(name: "education_cgpa", type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jblt_education", x => x.educationid);
                });

            migrationBuilder.CreateTable(
                name: "jblt_email",
                columns: table => new
                {
                    emailid = table.Column<int>(name: "email_id", type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    emailtype = table.Column<int>(name: "email_type", type: "integer", nullable: false),
                    emailaddress = table.Column<string>(name: "email_address", type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jblt_email", x => x.emailid);
                });

            migrationBuilder.CreateTable(
                name: "jblt_experience",
                columns: table => new
                {
                    experienceid = table.Column<int>(name: "experience_id", type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    experiencetype = table.Column<int>(name: "experience_type", type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jblt_experience", x => x.experienceid);
                });

            migrationBuilder.CreateTable(
                name: "jblt_personName",
                columns: table => new
                {
                    personnameid = table.Column<int>(name: "personname_id", type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    personNamefirstname = table.Column<string>(name: "personName_firstname", type: "text", nullable: true),
                    personNamemiddlename = table.Column<string>(name: "personName_middlename", type: "text", nullable: true),
                    personNamelastname = table.Column<string>(name: "personName_lastname", type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jblt_personName", x => x.personnameid);
                });

            migrationBuilder.CreateTable(
                name: "jblt_phone",
                columns: table => new
                {
                    jbltphoneid = table.Column<int>(name: "jblt_phoneid", type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    jbltcountrycode = table.Column<int>(name: "jblt_countrycode", type: "integer", nullable: false),
                    jbltphonenumber = table.Column<string>(name: "jblt_phonenumber", type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jblt_phone", x => x.jbltphoneid);
                });

            migrationBuilder.CreateTable(
                name: "jblt_qualification",
                columns: table => new
                {
                    qualificationid = table.Column<int>(name: "qualification_id", type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    qualificationtype = table.Column<int>(name: "qualification_type", type: "integer", nullable: false),
                    qualificationinformation = table.Column<string>(name: "qualification_information", type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jblt_qualification", x => x.qualificationid);
                });

            migrationBuilder.CreateTable(
                name: "jblt_role",
                columns: table => new
                {
                    roleroleid = table.Column<int>(name: "role_roleid", type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    rolename = table.Column<int>(name: "role_name", type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jblt_role", x => x.roleroleid);
                });

            migrationBuilder.CreateTable(
                name: "jblt_skill",
                columns: table => new
                {
                    skillid = table.Column<int>(name: "skill_id", type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jblt_skill", x => x.skillid);
                });

            migrationBuilder.CreateTable(
                name: "jblt_userAddress",
                columns: table => new
                {
                    addressid = table.Column<int>(name: "address_id", type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    addressstreet = table.Column<string>(name: "address_street", type: "text", nullable: true),
                    addresscity = table.Column<string>(name: "address_city", type: "text", nullable: true),
                    addressstate = table.Column<string>(name: "address_state", type: "text", nullable: true),
                    addresspostalCode = table.Column<string>(name: "address_postalCode", type: "text", nullable: true),
                    addresscountry = table.Column<string>(name: "address_country", type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jblt_userAddress", x => x.addressid);
                });

            migrationBuilder.CreateTable(
                name: "jblt_loginuser",
                columns: table => new
                {
                    loginuserid = table.Column<int>(name: "loginuser_id", type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    loginuseraddress = table.Column<string>(name: "loginuser_address", type: "text", nullable: false),
                    loginuserpassword = table.Column<string>(name: "loginuser_password", type: "text", nullable: false),
                    PersonNameId = table.Column<int>(type: "integer", nullable: true),
                    loginuseraccountstatus = table.Column<int>(name: "loginuser_accountstatus", type: "integer", nullable: false),
                    loginuseraccountcreated = table.Column<bool>(name: "loginuser_accountcreated", type: "boolean", nullable: false),
                    loginuserlogintime = table.Column<DateTime>(name: "loginuser_logintime", type: "timestamp with time zone", nullable: false),
                    loginuseripaddress = table.Column<string>(name: "loginuser_ipaddress", type: "text", nullable: true),
                    loginuserrole = table.Column<int>(name: "loginuser_role", type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jblt_loginuser", x => x.loginuserid);
                    table.ForeignKey(
                        name: "FK_jblt_loginuser_jblt_personName_PersonNameId",
                        column: x => x.PersonNameId,
                        principalTable: "jblt_personName",
                        principalColumn: "personname_id");
                });

            migrationBuilder.CreateTable(
                name: "jblt_registerUser",
                columns: table => new
                {
                    jbltregisterid = table.Column<int>(name: "jblt_registerid", type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Salt = table.Column<string>(type: "text", nullable: true),
                    PersonNameId = table.Column<int>(type: "integer", nullable: false),
                    UserEmailId = table.Column<int>(type: "integer", nullable: false),
                    jbltpassword = table.Column<string>(name: "jblt_password", type: "character varying(101)", maxLength: 101, nullable: false),
                    jbltconfirmpassword = table.Column<string>(name: "jblt_confirmpassword", type: "character varying(101)", maxLength: 101, nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "jblt_companyprofile",
                columns: table => new
                {
                    companyprofileid = table.Column<int>(name: "companyprofile_id", type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProfileInfo = table.Column<string>(type: "text", nullable: true),
                    CompanyAddressId = table.Column<int>(type: "integer", nullable: true),
                    ContactPhoneId = table.Column<int>(type: "integer", nullable: true),
                    ContactEmailId = table.Column<int>(type: "integer", nullable: true),
                    companywebsite = table.Column<string>(name: "company_website", type: "text", nullable: true),
                    IndustryType = table.Column<int>(type: "integer", nullable: true)
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
                });

            migrationBuilder.CreateTable(
                name: "jblt_seeker",
                columns: table => new
                {
                    seekerid = table.Column<int>(name: "seeker_id", type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PhoneId = table.Column<int>(type: "integer", nullable: true),
                    AddressId = table.Column<int>(type: "integer", nullable: true),
                    SkillsId = table.Column<int>(type: "integer", nullable: true),
                    EducationId = table.Column<int>(type: "integer", nullable: true),
                    ExperienceId = table.Column<int>(type: "integer", nullable: true),
                    seekerdob = table.Column<DateTime>(name: "seeker_dob", type: "timestamp with time zone", nullable: true),
                    QualificationsId = table.Column<int>(type: "integer", nullable: true),
                    seekerprofilesummary = table.Column<string>(name: "seeker_profilesummary", type: "text", nullable: true),
                    seekerlinkedin = table.Column<string>(name: "seeker_linkedin", type: "text", nullable: true),
                    Portfolio = table.Column<string>(type: "text", nullable: true),
                    jobinterests = table.Column<string>(name: "job_interests", type: "text", nullable: true),
                    jobachievements = table.Column<string>(name: "job_achievements", type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jblt_seeker", x => x.seekerid);
                    table.ForeignKey(
                        name: "FK_jblt_seeker_jblt_education_EducationId",
                        column: x => x.EducationId,
                        principalTable: "jblt_education",
                        principalColumn: "education_id");
                    table.ForeignKey(
                        name: "FK_jblt_seeker_jblt_experience_ExperienceId",
                        column: x => x.ExperienceId,
                        principalTable: "jblt_experience",
                        principalColumn: "experience_id");
                    table.ForeignKey(
                        name: "FK_jblt_seeker_jblt_phone_PhoneId",
                        column: x => x.PhoneId,
                        principalTable: "jblt_phone",
                        principalColumn: "jblt_phoneid");
                    table.ForeignKey(
                        name: "FK_jblt_seeker_jblt_qualification_QualificationsId",
                        column: x => x.QualificationsId,
                        principalTable: "jblt_qualification",
                        principalColumn: "qualification_id");
                    table.ForeignKey(
                        name: "FK_jblt_seeker_jblt_skill_SkillsId",
                        column: x => x.SkillsId,
                        principalTable: "jblt_skill",
                        principalColumn: "skill_id");
                    table.ForeignKey(
                        name: "FK_jblt_seeker_jblt_userAddress_AddressId",
                        column: x => x.AddressId,
                        principalTable: "jblt_userAddress",
                        principalColumn: "address_id");
                });

            migrationBuilder.CreateTable(
                name: "jblt_company",
                columns: table => new
                {
                    companyid = table.Column<int>(name: "company_id", type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyname = table.Column<string>(name: "company_name", type: "text", nullable: true),
                    ProfileId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jblt_company", x => x.companyid);
                    table.ForeignKey(
                        name: "FK_jblt_company_jblt_companyprofile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "jblt_companyprofile",
                        principalColumn: "companyprofile_id");
                });

            migrationBuilder.CreateTable(
                name: "jblt_job",
                columns: table => new
                {
                    jobid = table.Column<int>(name: "job_id", type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CompanyDescriptionId = table.Column<int>(type: "integer", nullable: true),
                    jobtitle = table.Column<string>(name: "job_title", type: "text", nullable: true),
                    jobdescription = table.Column<string>(name: "job_description", type: "text", nullable: true),
                    jobtype = table.Column<string>(name: "job_type", type: "text", nullable: true),
                    JobAddressId = table.Column<int>(type: "integer", nullable: true),
                    jobvacancies = table.Column<int>(name: "job_vacancies", type: "integer", nullable: true),
                    jobbasicpay = table.Column<string>(name: "job_basic_pay", type: "text", nullable: true),
                    jobfunctionalarea = table.Column<string>(name: "job_functional_area", type: "text", nullable: true),
                    SkillsRequiredId = table.Column<int>(type: "integer", nullable: true),
                    RequiredQualificationId = table.Column<int>(type: "integer", nullable: true),
                    RequiredExperienceId = table.Column<int>(type: "integer", nullable: true),
                    preferredqualifications = table.Column<string>(name: "preferred_qualifications", type: "text", nullable: true),
                    jobresponsibility = table.Column<string>(name: "job_responsibility", type: "text", nullable: true),
                    jobbenefits = table.Column<string>(name: "job_benefits", type: "text", nullable: true),
                    jobtags = table.Column<string>(name: "job_tags", type: "text", nullable: true),
                    jobworkenvironment = table.Column<string>(name: "job_workenvironment", type: "text", nullable: true),
                    jobpostingdate = table.Column<DateTime>(name: "job_posting_date", type: "timestamp with time zone", nullable: true),
                    jobapplicationdeadline = table.Column<DateTime>(name: "job_applicationdeadline", type: "timestamp with time zone", nullable: true)
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
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_jblt_seeker_AddressId",
                table: "jblt_seeker",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_jblt_seeker_EducationId",
                table: "jblt_seeker",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_jblt_seeker_ExperienceId",
                table: "jblt_seeker",
                column: "ExperienceId");

            migrationBuilder.CreateIndex(
                name: "IX_jblt_seeker_PhoneId",
                table: "jblt_seeker",
                column: "PhoneId");

            migrationBuilder.CreateIndex(
                name: "IX_jblt_seeker_QualificationsId",
                table: "jblt_seeker",
                column: "QualificationsId");

            migrationBuilder.CreateIndex(
                name: "IX_jblt_seeker_SkillsId",
                table: "jblt_seeker",
                column: "SkillsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "jblt_job");

            migrationBuilder.DropTable(
                name: "jblt_loginuser");

            migrationBuilder.DropTable(
                name: "jblt_registerUser");

            migrationBuilder.DropTable(
                name: "jblt_role");

            migrationBuilder.DropTable(
                name: "jblt_seeker");

            migrationBuilder.DropTable(
                name: "jblt_company");

            migrationBuilder.DropTable(
                name: "jblt_personName");

            migrationBuilder.DropTable(
                name: "jblt_education");

            migrationBuilder.DropTable(
                name: "jblt_experience");

            migrationBuilder.DropTable(
                name: "jblt_qualification");

            migrationBuilder.DropTable(
                name: "jblt_skill");

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
