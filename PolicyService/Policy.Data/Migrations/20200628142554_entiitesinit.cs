using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Policy.Data.EF.Migrations
{
    public partial class entiitesinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contract");

            migrationBuilder.DropTable(
                name: "ProfileUser");

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<long>(nullable: false),
                    UpdatedBy = table.Column<long>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    AddressDetails = table.Column<string>(nullable: true),
                    ProvinceOrCityId = table.Column<long>(nullable: false),
                    DistrictId = table.Column<long>(nullable: false),
                    WardId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<long>(nullable: false),
                    UpdatedBy = table.Column<long>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ProvinceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<long>(nullable: false),
                    UpdatedBy = table.Column<long>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<long>(nullable: false),
                    UpdatedBy = table.Column<long>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    AddressId = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: true),
                    Fullname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<long>(nullable: false),
                    UpdatedBy = table.Column<long>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    AddressId = table.Column<string>(nullable: true),
                    Fullname = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: true),
                    Mobile = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ward",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<long>(nullable: false),
                    UpdatedBy = table.Column<long>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    DistrictId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ward", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "Province");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "Ward");

            migrationBuilder.CreateTable(
                name: "Contract",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contract", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProfileUser",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileUser", x => x.Id);
                });
        }
    }
}
