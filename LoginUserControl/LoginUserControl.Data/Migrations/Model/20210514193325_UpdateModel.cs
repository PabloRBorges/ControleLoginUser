using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginUserControl.Data.Migrations.Model
{
    public partial class UpdateModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bombas_Contratos_ContratoId",
                table: "Bombas");

            migrationBuilder.DropForeignKey(
                name: "FK_Contratos_Clientes_ClienteFK",
                table: "Contratos");

            migrationBuilder.DropForeignKey(
                name: "FK_Placas_Contratos_ContratoId",
                table: "Placas");

            migrationBuilder.DropForeignKey(
                name: "FK_Sensor_Contratos_ContratoId",
                table: "Sensor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Placas",
                table: "Placas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contratos",
                table: "Contratos");

            migrationBuilder.RenameTable(
                name: "Placas",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "Contratos",
                newName: "Customers");

            migrationBuilder.RenameIndex(
                name: "IX_Placas_ContratoId",
                table: "Orders",
                newName: "IX_Orders_ContratoId");

            migrationBuilder.RenameIndex(
                name: "IX_Contratos_ClienteFK",
                table: "Customers",
                newName: "IX_Customers_ClienteFK");

            migrationBuilder.AddColumn<bool>(
                name: "BloqueioContrato",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EmUso",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bombas_Customers_ContratoId",
                table: "Bombas",
                column: "ContratoId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Clientes_ClienteFK",
                table: "Customers",
                column: "ClienteFK",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_ContratoId",
                table: "Orders",
                column: "ContratoId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sensor_Customers_ContratoId",
                table: "Sensor",
                column: "ContratoId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bombas_Customers_ContratoId",
                table: "Bombas");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Clientes_ClienteFK",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_ContratoId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Sensor_Customers_ContratoId",
                table: "Sensor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "BloqueioContrato",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "EmUso",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Placas");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Contratos");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ContratoId",
                table: "Placas",
                newName: "IX_Placas_ContratoId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_ClienteFK",
                table: "Contratos",
                newName: "IX_Contratos_ClienteFK");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Placas",
                table: "Placas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contratos",
                table: "Contratos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bombas_Contratos_ContratoId",
                table: "Bombas",
                column: "ContratoId",
                principalTable: "Contratos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contratos_Clientes_ClienteFK",
                table: "Contratos",
                column: "ClienteFK",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Placas_Contratos_ContratoId",
                table: "Placas",
                column: "ContratoId",
                principalTable: "Contratos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sensor_Contratos_ContratoId",
                table: "Sensor",
                column: "ContratoId",
                principalTable: "Contratos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
