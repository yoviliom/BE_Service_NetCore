using Microsoft.EntityFrameworkCore.Migrations;

namespace Policy.Data.EF.Migrations
{
    public partial class entiitesinit1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Province",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Province",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string))
                .Annotation("SqlServer:Identity", "1, 1");
        }
    }
}
