using Microsoft.EntityFrameworkCore.Migrations;

namespace RepasoParcial2.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asignaturas",
                columns: table => new
                {
                    AsignaturaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Codigo = table.Column<string>(nullable: false),
                    Descripcion = table.Column<string>(nullable: false),
                    PreRequisitos = table.Column<string>(nullable: false),
                    Creditos = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignaturas", x => x.AsignaturaId);
                });

            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    EstudiantesId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombres = table.Column<string>(nullable: true),
                    Matricula = table.Column<string>(nullable: true),
                    Deuda = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.EstudiantesId);
                });

            migrationBuilder.CreateTable(
                name: "Inscripcion",
                columns: table => new
                {
                    InscripcionId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EstudianteId = table.Column<int>(nullable: false),
                    Semestre = table.Column<string>(nullable: true),
                    Limite = table.Column<int>(nullable: false),
                    Tomados = table.Column<int>(nullable: false),
                    Disponible = table.Column<int>(nullable: false),
                    Monto = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscripcion", x => x.InscripcionId);
                });

            migrationBuilder.CreateTable(
                name: "InscripcionDetalles",
                columns: table => new
                {
                    InscripcionDetalleId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InscripcionId = table.Column<int>(nullable: false),
                    AsignaturaId = table.Column<int>(nullable: false),
                    DescripcionAsignatura = table.Column<string>(nullable: true),
                    Creditos = table.Column<int>(nullable: false),
                    Subtotal = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InscripcionDetalles", x => x.InscripcionDetalleId);
                    table.ForeignKey(
                        name: "FK_InscripcionDetalles_Inscripcion_InscripcionId",
                        column: x => x.InscripcionId,
                        principalTable: "Inscripcion",
                        principalColumn: "InscripcionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InscripcionDetalles_InscripcionId",
                table: "InscripcionDetalles",
                column: "InscripcionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asignaturas");

            migrationBuilder.DropTable(
                name: "Estudiantes");

            migrationBuilder.DropTable(
                name: "InscripcionDetalles");

            migrationBuilder.DropTable(
                name: "Inscripcion");
        }
    }
}
