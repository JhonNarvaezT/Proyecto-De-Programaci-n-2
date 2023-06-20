using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ActaNotasAPI.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asignaturas",
                columns: table => new
                {
                    AsignaturaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AsignaturaNombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Semestre = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Creditos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignaturas", x => x.AsignaturaId);
                });

            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    GrupoId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Año = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.GrupoId);
                });

            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    EstudianteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GrupoId = table.Column<int>(type: "int", nullable: false),
                    Carnet = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.EstudianteId);
                    table.ForeignKey(
                        name: "FK_Estudiantes_Grupos_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupos",
                        principalColumn: "GrupoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Calificacions",
                columns: table => new
                {
                    CalificacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstudianteId = table.Column<int>(type: "int", nullable: false),
                    AsignaturaId = table.Column<int>(type: "int", nullable: false),
                    nota = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calificacions", x => x.CalificacionId);
                    table.ForeignKey(
                        name: "FK_Calificacions_Asignaturas_AsignaturaId",
                        column: x => x.AsignaturaId,
                        principalTable: "Asignaturas",
                        principalColumn: "AsignaturaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Calificacions_Estudiantes_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Estudiantes",
                        principalColumn: "EstudianteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Asignaturas",
                columns: new[] { "AsignaturaId", "AsignaturaNombre", "Creditos", "Semestre" },
                values: new object[,]
                {
                    { 1, "Introduccion a la Programacion", 4, "Primer Semestre" },
                    { 2, "Calculo 1", 4, "Primer Semestre" }
                });

            migrationBuilder.InsertData(
                table: "Grupos",
                columns: new[] { "GrupoId", "Año", "Nombre" },
                values: new object[,]
                {
                    { 1, "1", "1M1-IS" },
                    { 2, "1", "1M1-IS" }
                });

            migrationBuilder.InsertData(
                table: "Estudiantes",
                columns: new[] { "EstudianteId", "Carnet", "GrupoId", "Nombre" },
                values: new object[,]
                {
                    { 1, "2023-0101U", 2, "Carlos Morales" },
                    { 2, "2023-0102U", 2, "Maria Lopez" },
                    { 3, "2023-0103U", 1, "John Reyes" }
                });

            migrationBuilder.InsertData(
                table: "Calificacions",
                columns: new[] { "CalificacionId", "AsignaturaId", "EstudianteId", "nota" },
                values: new object[,]
                {
                    { 1, 1, 1, 100f },
                    { 2, 1, 1, 100f },
                    { 3, 1, 1, 80f },
                    { 4, 2, 1, 90f },
                    { 5, 2, 1, 100f },
                    { 6, 2, 1, 60f },
                    { 7, 1, 2, 90f },
                    { 8, 1, 2, 70f },
                    { 9, 1, 2, 100f },
                    { 10, 1, 2, 90f },
                    { 11, 2, 2, 70f },
                    { 12, 2, 2, 100f },
                    { 13, 1, 3, 75f },
                    { 14, 1, 3, 90f },
                    { 15, 1, 3, 100f },
                    { 16, 2, 3, 90f },
                    { 17, 2, 3, 70f },
                    { 18, 2, 3, 100f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calificacions_AsignaturaId",
                table: "Calificacions",
                column: "AsignaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Calificacions_EstudianteId",
                table: "Calificacions",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_GrupoId",
                table: "Estudiantes",
                column: "GrupoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calificacions");

            migrationBuilder.DropTable(
                name: "Asignaturas");

            migrationBuilder.DropTable(
                name: "Estudiantes");

            migrationBuilder.DropTable(
                name: "Grupos");
        }
    }
}
