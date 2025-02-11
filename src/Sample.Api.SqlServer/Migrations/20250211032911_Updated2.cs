using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sample.Api.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Updated2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "job_properties",
                schema: "sample",
                table: "job_saga",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "job_properties",
                schema: "sample",
                table: "job_saga");
        }
    }
}
