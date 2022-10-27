using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project4.Migrations
{
    public partial class Initital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    International = table.Column<bool>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    ExpectedHours = table.Column<string>(nullable: true),
                    Semester = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    ByuId = table.Column<int>(nullable: false),
                    PositionType = table.Column<string>(nullable: true),
                    ClassCode = table.Column<string>(nullable: true),
                    EmplRecord = table.Column<int>(nullable: false),
                    Supervisor = table.Column<string>(nullable: true),
                    HireDate = table.Column<DateTime>(nullable: false),
                    PayRate = table.Column<float>(nullable: false),
                    LastPayIncrease = table.Column<DateTime>(nullable: false),
                    PayIncreaseAmount = table.Column<float>(nullable: false),
                    IncreaseInputDate = table.Column<DateTime>(nullable: false),
                    YearInProgram = table.Column<string>(nullable: true),
                    PayGradTuition = table.Column<bool>(nullable: false),
                    NameChangeCompleted = table.Column<bool>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    Terminated = table.Column<bool>(nullable: false),
                    TerminationDate = table.Column<DateTime>(nullable: false),
                    QualtricsSurveySent = table.Column<bool>(nullable: false),
                    SubmittedEForm = table.Column<bool>(nullable: false),
                    EFormSubmissionDate = table.Column<DateTime>(nullable: false),
                    WorkAuthReceived = table.Column<bool>(nullable: false),
                    AuthToWorkEmailSentDate = table.Column<DateTime>(nullable: false),
                    ByuName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.EmployeeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");
        }
    }
}
