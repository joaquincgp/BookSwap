using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookSwap.Migrations
{
    /// <inheritdoc />
    public partial class DB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemCarritos_Carrito_CarritoId1",
                table: "ItemCarritos");

            migrationBuilder.DropIndex(
                name: "IX_ItemCarritos_CarritoId1",
                table: "ItemCarritos");

            migrationBuilder.DropColumn(
                name: "CarritoId1",
                table: "ItemCarritos");

            migrationBuilder.AlterColumn<int>(
                name: "CarritoId",
                table: "ItemCarritos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ItemCarritos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCarritos_CarritoId",
                table: "ItemCarritos",
                column: "CarritoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemCarritos_Carrito_CarritoId",
                table: "ItemCarritos",
                column: "CarritoId",
                principalTable: "Carrito",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemCarritos_Carrito_CarritoId",
                table: "ItemCarritos");

            migrationBuilder.DropIndex(
                name: "IX_ItemCarritos_CarritoId",
                table: "ItemCarritos");

            migrationBuilder.AlterColumn<string>(
                name: "CarritoId",
                table: "ItemCarritos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "ItemCarritos",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CarritoId1",
                table: "ItemCarritos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemCarritos_CarritoId1",
                table: "ItemCarritos",
                column: "CarritoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemCarritos_Carrito_CarritoId1",
                table: "ItemCarritos",
                column: "CarritoId1",
                principalTable: "Carrito",
                principalColumn: "Id");
        }
    }
}
