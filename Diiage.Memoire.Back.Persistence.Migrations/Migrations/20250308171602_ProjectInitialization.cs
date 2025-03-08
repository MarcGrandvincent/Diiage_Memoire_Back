using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diiage.Memoire.Back.Persistence.Migration.Migrations
{
    /// <inheritdoc />
    public partial class ProjectInitialization : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "diiage-memoire-core");

            migrationBuilder.CreateTable(
                name: "TankFamilies",
                schema: "diiage-memoire-core",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentFamilyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TankFamilies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TankFamilies_TankFamilies_ParentFamilyId",
                        column: x => x.ParentFamilyId,
                        principalSchema: "diiage-memoire-core",
                        principalTable: "TankFamilies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ThirdParties",
                schema: "diiage-memoire-core",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThirdParties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                schema: "diiage-memoire-core",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Variables",
                schema: "diiage-memoire-core",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kind = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tanks",
                schema: "diiage-memoire-core",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TankFamilyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tanks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tanks_TankFamilies_Id",
                        column: x => x.Id,
                        principalSchema: "diiage-memoire-core",
                        principalTable: "TankFamilies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                schema: "diiage-memoire-core",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    ThirdPartyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documents_ThirdParties_ThirdPartyId",
                        column: x => x.ThirdPartyId,
                        principalSchema: "diiage-memoire-core",
                        principalTable: "ThirdParties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AllowedVariables",
                schema: "diiage-memoire-core",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VariableId = table.Column<int>(type: "int", nullable: false),
                    Kind = table.Column<int>(type: "int", nullable: false),
                    TankDaoId = table.Column<int>(type: "int", nullable: true),
                    Value = table.Column<bool>(type: "bit", nullable: true),
                    AllowedVariableNumericDao_Value = table.Column<int>(type: "int", nullable: true),
                    UnitId = table.Column<int>(type: "int", nullable: true),
                    AllowedVariableStringDao_Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllowedVariables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AllowedVariables_Tanks_TankDaoId",
                        column: x => x.TankDaoId,
                        principalSchema: "diiage-memoire-core",
                        principalTable: "Tanks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AllowedVariables_Units_UnitId",
                        column: x => x.UnitId,
                        principalSchema: "diiage-memoire-core",
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AllowedVariables_Variables_VariableId",
                        column: x => x.VariableId,
                        principalSchema: "diiage-memoire-core",
                        principalTable: "Variables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DocumentRows",
                schema: "diiage-memoire-core",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    DocumentId = table.Column<int>(type: "int", nullable: false),
                    TankId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentRows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentRows_Documents_Id",
                        column: x => x.Id,
                        principalSchema: "diiage-memoire-core",
                        principalTable: "Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocumentRows_Tanks_TankId",
                        column: x => x.TankId,
                        principalSchema: "diiage-memoire-core",
                        principalTable: "Tanks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AllowedVariables_Kind",
                schema: "diiage-memoire-core",
                table: "AllowedVariables",
                column: "Kind");

            migrationBuilder.CreateIndex(
                name: "IX_AllowedVariables_TankDaoId",
                schema: "diiage-memoire-core",
                table: "AllowedVariables",
                column: "TankDaoId");

            migrationBuilder.CreateIndex(
                name: "IX_AllowedVariables_UnitId",
                schema: "diiage-memoire-core",
                table: "AllowedVariables",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_AllowedVariables_VariableId",
                schema: "diiage-memoire-core",
                table: "AllowedVariables",
                column: "VariableId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentRows_TankId",
                schema: "diiage-memoire-core",
                table: "DocumentRows",
                column: "TankId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_ThirdPartyId",
                schema: "diiage-memoire-core",
                table: "Documents",
                column: "ThirdPartyId");

            migrationBuilder.CreateIndex(
                name: "IX_TankFamilies_ParentFamilyId",
                schema: "diiage-memoire-core",
                table: "TankFamilies",
                column: "ParentFamilyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllowedVariables",
                schema: "diiage-memoire-core");

            migrationBuilder.DropTable(
                name: "DocumentRows",
                schema: "diiage-memoire-core");

            migrationBuilder.DropTable(
                name: "Units",
                schema: "diiage-memoire-core");

            migrationBuilder.DropTable(
                name: "Variables",
                schema: "diiage-memoire-core");

            migrationBuilder.DropTable(
                name: "Documents",
                schema: "diiage-memoire-core");

            migrationBuilder.DropTable(
                name: "Tanks",
                schema: "diiage-memoire-core");

            migrationBuilder.DropTable(
                name: "ThirdParties",
                schema: "diiage-memoire-core");

            migrationBuilder.DropTable(
                name: "TankFamilies",
                schema: "diiage-memoire-core");
        }
    }
}
