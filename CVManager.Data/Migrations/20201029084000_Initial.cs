using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CVManager.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acount",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    ObjectId = table.Column<Guid>(nullable: false),
                    ObjectRole = table.Column<string>(nullable: false, defaultValue: "ROLE_USER"),
                    createDate = table.Column<DateTime>(nullable: false),
                    modifyDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acount", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Enterprise",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Gender = table.Column<bool>(nullable: false),
                    Skype = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: false),
                    createDate = table.Column<DateTime>(nullable: false),
                    modifyDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enterprise", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    School = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Area = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false, defaultValue: true),
                    createDate = table.Column<DateTime>(nullable: false),
                    modifyDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Enterprise_Info",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Company_Name = table.Column<string>(nullable: false),
                    Tax_Code = table.Column<string>(nullable: false),
                    Area = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Website = table.Column<string>(nullable: false),
                    Scale = table.Column<string>(nullable: false),
                    ID_Enterprise = table.Column<Guid>(nullable: false),
                    createDate = table.Column<DateTime>(nullable: false),
                    modifyDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enterprise_Info", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Enterprise_Info_Enterprise_ID_Enterprise",
                        column: x => x.ID_Enterprise,
                        principalTable: "Enterprise",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    ExactAddress = table.Column<string>(nullable: false),
                    Position = table.Column<string>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Salary = table.Column<string>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Experience = table.Column<int>(nullable: false),
                    Submit_Deadline = table.Column<DateTime>(nullable: false),
                    Reciever = table.Column<string>(nullable: false),
                    Email_Reciever = table.Column<string>(nullable: false),
                    Phone_Reciever = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Require = table.Column<string>(nullable: false),
                    Benefit = table.Column<string>(nullable: false),
                    Skill = table.Column<string>(nullable: false),
                    Status = table.Column<bool>(nullable: false, defaultValue: true),
                    createDate = table.Column<DateTime>(nullable: false),
                    modifyDate = table.Column<DateTime>(nullable: false),
                    EnterpriseID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Post_Enterprise_EnterpriseID",
                        column: x => x.EnterpriseID,
                        principalTable: "Enterprise",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Result = table.Column<bool>(nullable: false),
                    createDate = table.Column<DateTime>(nullable: false),
                    modifyDate = table.Column<DateTime>(nullable: false),
                    UserID = table.Column<Guid>(nullable: true),
                    EnterpriseID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Contact_Enterprise_EnterpriseID",
                        column: x => x.EnterpriseID,
                        principalTable: "Enterprise",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contact_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CV",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Html = table.Column<string>(nullable: false),
                    Css = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: false),
                    Path = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false, defaultValue: 1),
                    Is_choosen = table.Column<bool>(nullable: false, defaultValue: true),
                    createDate = table.Column<DateTime>(nullable: false),
                    modifyDate = table.Column<DateTime>(nullable: false),
                    UserID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CV", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CV_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contact_Info",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    ID_Contact = table.Column<Guid>(nullable: false),
                    createDate = table.Column<DateTime>(nullable: false),
                    modifyDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact_Info", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Contact_Info_Contact_ID_Contact",
                        column: x => x.ID_Contact,
                        principalTable: "Contact",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contact_EnterpriseID",
                table: "Contact",
                column: "EnterpriseID");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_UserID",
                table: "Contact",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_Info_ID_Contact",
                table: "Contact_Info",
                column: "ID_Contact",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CV_UserID",
                table: "CV",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Enterprise_Info_ID_Enterprise",
                table: "Enterprise_Info",
                column: "ID_Enterprise",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Post_EnterpriseID",
                table: "Post",
                column: "EnterpriseID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acount");

            migrationBuilder.DropTable(
                name: "Contact_Info");

            migrationBuilder.DropTable(
                name: "CV");

            migrationBuilder.DropTable(
                name: "Enterprise_Info");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Enterprise");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
