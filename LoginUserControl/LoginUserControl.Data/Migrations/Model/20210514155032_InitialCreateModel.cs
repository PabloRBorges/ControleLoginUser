using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginUserControl.Data.Migrations.Model
{
    public partial class InitialCreateModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RazaoSocial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Responsavel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalGPS = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DadosRecebidos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    IdPlaca = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DadosJson = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DadosRecebidos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contratos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Validade = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValorContrato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClienteFK = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contratos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contratos_Clientes_ClienteFK",
                        column: x => x.ClienteFK,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bombas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataFabricacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoTubo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diametro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vazao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contrato_FK = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContratoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bombas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bombas_Contratos_ContratoId",
                        column: x => x.ContratoId,
                        principalTable: "Contratos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Placas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    MacAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataFabricacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VersaoCodigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContratoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Placas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Placas_Contratos_ContratoId",
                        column: x => x.ContratoId,
                        principalTable: "Contratos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sensor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataCompra = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vazao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmUso = table.Column<bool>(type: "bit", nullable: false),
                    ContratoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sensor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sensor_Contratos_ContratoId",
                        column: x => x.ContratoId,
                        principalTable: "Contratos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bombas_ContratoId",
                table: "Bombas",
                column: "ContratoId");

            migrationBuilder.CreateIndex(
                name: "IX_Contratos_ClienteFK",
                table: "Contratos",
                column: "ClienteFK");

            migrationBuilder.CreateIndex(
                name: "IX_Placas_ContratoId",
                table: "Placas",
                column: "ContratoId");

            migrationBuilder.CreateIndex(
                name: "IX_Sensor_ContratoId",
                table: "Sensor",
                column: "ContratoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bombas");

            migrationBuilder.DropTable(
                name: "DadosRecebidos");

            migrationBuilder.DropTable(
                name: "Placas");

            migrationBuilder.DropTable(
                name: "Sensor");

            migrationBuilder.DropTable(
                name: "Contratos");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
