using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project01.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    AD_Id = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AD_FName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AD_LName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AD_Birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AD_Address = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    AD_Phone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    AD_Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    ACC_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.AD_Id);
                });

            migrationBuilder.CreateTable(
                name: "Grade",
                columns: table => new
                {
                    G_Id = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    G_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grade", x => x.G_Id);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    PST_Id = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PST_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.PST_Id);
                });

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    SD_Id = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SD_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    C_Id = table.Column<int>(type: "int", nullable: false),
                    SD_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SD_Status = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CR_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.SD_Id);
                });

            migrationBuilder.CreateTable(
                name: "TestCaterogy",
                columns: table => new
                {
                    TC_Id = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TC_Name = table.Column<int>(type: "int", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestCaterogy", x => x.TC_Id);
                });

            migrationBuilder.CreateTable(
                name: "Transcript",
                columns: table => new
                {
                    TS_Id = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TS_Name = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    TP_Id = table.Column<int>(type: "int", nullable: false),
                    TS_Point = table.Column<float>(type: "real", nullable: false),
                    TS_Total = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transcript", x => x.TS_Id);
                });

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    C_Id = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    C_Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    G_Id = table.Column<int>(type: "int", nullable: false),
                    SY_Id = table.Column<int>(type: "int", nullable: false),
                    SD_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.C_Id);
                    table.ForeignKey(
                        name: "FK_Class_Grade_G_Id",
                        column: x => x.G_Id,
                        principalTable: "Grade",
                        principalColumn: "G_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Class_Schedule_C_Id",
                        column: x => x.C_Id,
                        principalTable: "Schedule",
                        principalColumn: "SD_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SchoolYear",
                columns: table => new
                {
                    SY_Id = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SY_Year = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    C_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolYear", x => x.SY_Id);
                    table.ForeignKey(
                        name: "FK_SchoolYear_Class_C_Id",
                        column: x => x.C_Id,
                        principalTable: "Class",
                        principalColumn: "C_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    S_Id = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    S_FName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    S_LName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    S_Phone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    S_Address = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    S_Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    ACC_Id = table.Column<int>(type: "int", nullable: false),
                    C_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.S_Id);
                    table.ForeignKey(
                        name: "FK_Student_Class_C_Id",
                        column: x => x.C_Id,
                        principalTable: "Class",
                        principalColumn: "C_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Semester",
                columns: table => new
                {
                    SMT_Id = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    SMT_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SY_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semester", x => x.SMT_Id);
                    table.ForeignKey(
                        name: "FK_Semester_SchoolYear_SMT_Id",
                        column: x => x.SMT_Id,
                        principalTable: "SchoolYear",
                        principalColumn: "SY_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    ACC_Id = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    ACC_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ACC_Pw = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PST_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.ACC_Id);
                    table.ForeignKey(
                        name: "FK_Account_Admin_ACC_Id",
                        column: x => x.ACC_Id,
                        principalTable: "Admin",
                        principalColumn: "AD_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Account_Position_PST_Id",
                        column: x => x.PST_Id,
                        principalTable: "Position",
                        principalColumn: "PST_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Account_Student_ACC_Id",
                        column: x => x.ACC_Id,
                        principalTable: "Student",
                        principalColumn: "S_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestPoint",
                columns: table => new
                {
                    TP_Id = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    SD_Id = table.Column<int>(type: "int", nullable: false),
                    TD_Id = table.Column<int>(type: "int", nullable: false),
                    TP_Name = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    TP_Point = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestPoint", x => x.TP_Id);
                    table.ForeignKey(
                        name: "FK_TestPoint_Student_SD_Id",
                        column: x => x.SD_Id,
                        principalTable: "Student",
                        principalColumn: "S_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestPoint_Transcript_TP_Id",
                        column: x => x.TP_Id,
                        principalTable: "Transcript",
                        principalColumn: "TS_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    SJ_Id = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SJ_Name = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    SJ_Lesson = table.Column<int>(type: "int", nullable: false),
                    SemesterrSMT_Id = table.Column<int>(type: "int", nullable: false),
                    AdminnAD_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.SJ_Id);
                    table.ForeignKey(
                        name: "FK_Subject_Admin_AdminnAD_Id",
                        column: x => x.AdminnAD_Id,
                        principalTable: "Admin",
                        principalColumn: "AD_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subject_Semester_SemesterrSMT_Id",
                        column: x => x.SemesterrSMT_Id,
                        principalTable: "Semester",
                        principalColumn: "SMT_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    CR_Id = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CR_Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CR_StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CR_EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CR_Link = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CR_Status = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    SJ_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.CR_Id);
                    table.ForeignKey(
                        name: "FK_Course_Subject_SJ_Id",
                        column: x => x.SJ_Id,
                        principalTable: "Subject",
                        principalColumn: "SJ_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    D_Id = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    D_Name = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    SJ_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.D_Id);
                    table.ForeignKey(
                        name: "FK_Document_Subject_SJ_Id",
                        column: x => x.SJ_Id,
                        principalTable: "Subject",
                        principalColumn: "SJ_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Test",
                columns: table => new
                {
                    T_Id = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    T_Name = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    TC_Id = table.Column<int>(type: "int", nullable: false),
                    SJ_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test", x => x.T_Id);
                    table.ForeignKey(
                        name: "FK_Test_Subject_SJ_Id",
                        column: x => x.SJ_Id,
                        principalTable: "Subject",
                        principalColumn: "SJ_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Test_TestCaterogy_TC_Id",
                        column: x => x.TC_Id,
                        principalTable: "TestCaterogy",
                        principalColumn: "TC_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleCourse",
                columns: table => new
                {
                    SC_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SD_Id = table.Column<int>(type: "int", nullable: false),
                    CR_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleCourse", x => x.SC_Id);
                    table.ForeignKey(
                        name: "FK_ScheduleCourse_Course_CR_Id",
                        column: x => x.CR_Id,
                        principalTable: "Course",
                        principalColumn: "CR_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScheduleCourse_Schedule_SD_Id",
                        column: x => x.SD_Id,
                        principalTable: "Schedule",
                        principalColumn: "SD_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TestDetail",
                columns: table => new
                {
                    TD_Id = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    C_Id = table.Column<int>(type: "int", nullable: false),
                    T_Id = table.Column<int>(type: "int", nullable: false),
                    T_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TD_Time = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestDetail", x => x.TD_Id);
                    table.ForeignKey(
                        name: "FK_TestDetail_Class_C_Id",
                        column: x => x.C_Id,
                        principalTable: "Class",
                        principalColumn: "C_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestDetail_Test_T_Id",
                        column: x => x.T_Id,
                        principalTable: "Test",
                        principalColumn: "T_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestDetail_TestPoint_TD_Id",
                        column: x => x.TD_Id,
                        principalTable: "TestPoint",
                        principalColumn: "TP_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_PST_Id",
                table: "Account",
                column: "PST_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Class_G_Id",
                table: "Class",
                column: "G_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Course_SJ_Id",
                table: "Course",
                column: "SJ_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Document_SJ_Id",
                table: "Document",
                column: "SJ_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleCourse_CR_Id",
                table: "ScheduleCourse",
                column: "CR_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleCourse_SD_Id",
                table: "ScheduleCourse",
                column: "SD_Id");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolYear_C_Id",
                table: "SchoolYear",
                column: "C_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_C_Id",
                table: "Student",
                column: "C_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_AdminnAD_Id",
                table: "Subject",
                column: "AdminnAD_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_SemesterrSMT_Id",
                table: "Subject",
                column: "SemesterrSMT_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Test_SJ_Id",
                table: "Test",
                column: "SJ_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Test_TC_Id",
                table: "Test",
                column: "TC_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TestDetail_C_Id",
                table: "TestDetail",
                column: "C_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TestDetail_T_Id",
                table: "TestDetail",
                column: "T_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TestPoint_SD_Id",
                table: "TestPoint",
                column: "SD_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "ScheduleCourse");

            migrationBuilder.DropTable(
                name: "TestDetail");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Test");

            migrationBuilder.DropTable(
                name: "TestPoint");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "TestCaterogy");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Transcript");

            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Semester");

            migrationBuilder.DropTable(
                name: "SchoolYear");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "Grade");

            migrationBuilder.DropTable(
                name: "Schedule");
        }
    }
}
