using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VP_7.Migrations
{
    public partial class Add_Agency_Name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Agencies_MyPropertyId",
                table: "Authors");

            migrationBuilder.RenameColumn(
                name: "MyPropertyId",
                table: "Authors",
                newName: "AgencyId");

            migrationBuilder.RenameIndex(
                name: "IX_Authors_MyPropertyId",
                table: "Authors",
                newName: "IX_Authors_AgencyId");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Agencies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_Agencies_AgencyId",
                table: "Authors",
                column: "AgencyId",
                principalTable: "Agencies",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Agencies_AgencyId",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Agencies");

            migrationBuilder.RenameColumn(
                name: "AgencyId",
                table: "Authors",
                newName: "MyPropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_Authors_AgencyId",
                table: "Authors",
                newName: "IX_Authors_MyPropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_Agencies_MyPropertyId",
                table: "Authors",
                column: "MyPropertyId",
                principalTable: "Agencies",
                principalColumn: "Id");
        }
    }
}
