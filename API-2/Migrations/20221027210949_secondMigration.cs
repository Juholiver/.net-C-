using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_2.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PessoaId",
                table: "contato",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_contato_PessoaId",
                table: "contato",
                column: "PessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_contato_pessoa_PessoaId",
                table: "contato",
                column: "PessoaId",
                principalTable: "pessoa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contato_pessoa_PessoaId",
                table: "contato");

            migrationBuilder.DropIndex(
                name: "IX_contato_PessoaId",
                table: "contato");

            migrationBuilder.DropColumn(
                name: "PessoaId",
                table: "contato");
        }
    }
}
