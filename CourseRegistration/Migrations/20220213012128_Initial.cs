using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseRegistration.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    InstructorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.InstructorId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseName", "CourseNumber", "Description" },
                values: new object[,]
                {
                    { 1, "C# Programming", "C1", "This course provides an introduction to C# in an integrated development environment using Visual Studio and the Microsoft .NET Core Framework." },
                    { 2, ".Net Core", "NC1", "It explores new Core features for familiar tasks such as testing, logging, data access, and networking." },
                    { 3, "ASP. Net Core", "ANC1", "The focus of the course is on creating applications with ASP.NET Core in order to build full stack Single Page Applications and REST APIs." },
                    { 4, "FrontEnd Framework", "ANC1", "Students will learn to develop dynamic Single Page Web Applications using three of today’s most popular front-end frameworks: Angular, React, and Vue." }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "InstructorId", "CourseId", "EmailAddress", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 1, "mlund@yahoo.com", "Michelle", "Lund" },
                    { 2, 2, "roblox@gmail.com", "Jason", "Capa" },
                    { 3, 3, "ADiaby@gmail.com", "Abraham", "Diaby" },
                    { 4, 4, "Sniper@gmail.com", "Gabriel", "Monzon" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "CourseId", "EmailAddress", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, 1, "cookie@gmail.com", "Rhiane", "Cruz", 1111234 },
                    { 2, 2, "minecraft@gmail.com", "Kassandra", "Ruiz", 2221234 },
                    { 3, 3, "music@gmail.com", "Leann", "Rymes", 3331234 },
                    { 4, 4, "lparas@gmail.com", "Luisa", "Paras", 4441234 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_CourseId",
                table: "Students",
                column: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
