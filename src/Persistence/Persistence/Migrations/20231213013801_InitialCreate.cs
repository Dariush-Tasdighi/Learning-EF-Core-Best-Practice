using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Ordering = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    InsertDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Ordering = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    InsertDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsEmailAddressVerified = table.Column<bool>(type: "bit", nullable: false),
                    EmailAddress = table.Column<string>(type: "varchar(254)", unicode: false, maxLength: 254, nullable: false),
                    Password = table.Column<string>(type: "varchar(44)", unicode: false, maxLength: 44, nullable: false),
                    InsertDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    EmailAddressVerificationKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserProfile",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProfile_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsersInGroups",
                columns: table => new
                {
                    GroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersInGroups", x => new { x.GroupId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UsersInGroups_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersInGroups_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "InsertDateTime", "IsActive", "Ordering", "Title", "UpdateDateTime" },
                values: new object[,]
                {
                    { new Guid("20f258d6-05f0-4cca-949c-4ebd0841674d"), new DateTimeOffset(new DateTime(2023, 12, 13, 5, 8, 1, 252, DateTimeKind.Unspecified).AddTicks(3954), new TimeSpan(0, 3, 30, 0, 0)), true, 10000, "Group 1", new DateTimeOffset(new DateTime(2023, 12, 13, 5, 8, 1, 252, DateTimeKind.Unspecified).AddTicks(3954), new TimeSpan(0, 3, 30, 0, 0)) },
                    { new Guid("766a89f3-0db0-416f-8fae-f0537338cbfd"), new DateTimeOffset(new DateTime(2023, 12, 13, 5, 8, 1, 252, DateTimeKind.Unspecified).AddTicks(4075), new TimeSpan(0, 3, 30, 0, 0)), true, 10000, "Group 3", new DateTimeOffset(new DateTime(2023, 12, 13, 5, 8, 1, 252, DateTimeKind.Unspecified).AddTicks(4075), new TimeSpan(0, 3, 30, 0, 0)) },
                    { new Guid("b7699fae-303a-44a7-824a-7e6adef2e621"), new DateTimeOffset(new DateTime(2023, 12, 13, 5, 8, 1, 252, DateTimeKind.Unspecified).AddTicks(4049), new TimeSpan(0, 3, 30, 0, 0)), true, 10000, "Group 2", new DateTimeOffset(new DateTime(2023, 12, 13, 5, 8, 1, 252, DateTimeKind.Unspecified).AddTicks(4049), new TimeSpan(0, 3, 30, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "InsertDateTime", "IsActive", "Ordering", "Title", "UpdateDateTime" },
                values: new object[,]
                {
                    { new Guid("52170142-d6f8-4202-ac5a-1062f5588887"), new DateTimeOffset(new DateTime(2023, 12, 13, 5, 8, 1, 32, DateTimeKind.Unspecified).AddTicks(935), new TimeSpan(0, 3, 30, 0, 0)), true, 10000, "User", new DateTimeOffset(new DateTime(2023, 12, 13, 5, 8, 1, 32, DateTimeKind.Unspecified).AddTicks(935), new TimeSpan(0, 3, 30, 0, 0)) },
                    { new Guid("6df1a10c-a2b2-4988-9411-8415eac9fa2a"), new DateTimeOffset(new DateTime(2023, 12, 13, 5, 8, 1, 34, DateTimeKind.Unspecified).AddTicks(7240), new TimeSpan(0, 3, 30, 0, 0)), true, 10000, "Administrator", new DateTimeOffset(new DateTime(2023, 12, 13, 5, 8, 1, 34, DateTimeKind.Unspecified).AddTicks(7240), new TimeSpan(0, 3, 30, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "EmailAddress", "EmailAddressVerificationKey", "InsertDateTime", "IsActive", "IsEmailAddressVerified", "Password", "RoleId", "UpdateDateTime" },
                values: new object[,]
                {
                    { new Guid("b84432a9-89e9-4c7f-aa1d-1743bf5fda8f"), "dariusht@gmail.com", new Guid("898bc2b1-0950-4abc-a29f-257dc448317f"), new DateTimeOffset(new DateTime(2023, 12, 13, 5, 8, 1, 252, DateTimeKind.Unspecified).AddTicks(4388), new TimeSpan(0, 3, 30, 0, 0)), true, false, "5KCpDlrAfVQ1xvJcTPfMVlvst5e7W4PFFbxCfvMqR3A=", new Guid("6df1a10c-a2b2-4988-9411-8415eac9fa2a"), new DateTimeOffset(new DateTime(2023, 12, 13, 5, 8, 1, 252, DateTimeKind.Unspecified).AddTicks(4388), new TimeSpan(0, 3, 30, 0, 0)) },
                    { new Guid("f41a31d7-b717-4a22-98db-4ba76cff2fae"), "alirezaalavi@gmail.com", new Guid("31c3be0a-b144-492d-bcfc-11b8e46dc53f"), new DateTimeOffset(new DateTime(2023, 12, 13, 5, 8, 1, 252, DateTimeKind.Unspecified).AddTicks(4451), new TimeSpan(0, 3, 30, 0, 0)), true, false, "5KCpDlrAfVQ1xvJcTPfMVlvst5e7W4PFFbxCfvMqR3A=", new Guid("52170142-d6f8-4202-ac5a-1062f5588887"), new DateTimeOffset(new DateTime(2023, 12, 13, 5, 8, 1, 252, DateTimeKind.Unspecified).AddTicks(4451), new TimeSpan(0, 3, 30, 0, 0)) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Groups_Title",
                table: "Groups",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Title",
                table: "Roles",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserProfile_UserId",
                table: "UserProfile",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_EmailAddress",
                table: "Users",
                column: "EmailAddress",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_EmailAddressVerificationKey",
                table: "Users",
                column: "EmailAddressVerificationKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersInGroups_UserId",
                table: "UsersInGroups",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserProfile");

            migrationBuilder.DropTable(
                name: "UsersInGroups");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
