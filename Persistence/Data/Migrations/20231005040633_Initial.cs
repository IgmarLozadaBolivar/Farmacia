using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "Nombre del cargo")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "Descripcion del cargo")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "Nombre de la categoria")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Especializacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "Nombre de la especializacion")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "Descripcion de la especializacion")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaRegistro = table.Column<DateTime>(type: "datetime", nullable: false, comment: "Fecha de registro de la especializacion")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especializacion", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "Nombre del genero")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Abreviatura = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false, comment: "Abreviatura del genero")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "Descripcion del genero")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "Nombre de la marca")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "Nombre del pais")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Capital = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "Capital del pais")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "Nombre del rol")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tipo Contacto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "Nombre del tipo de contacto")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo Contacto", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tipo Documento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "Nombre del tipo de documento")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Abreviatura = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false, comment: "Abreviatura del tipo de documento")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "Descripcion del tipo de documento")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo Documento", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tipo Persona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "Nombre del tipo de persona")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "Descripcion del tipo de persona")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo Persona", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tipo Presentacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "Nombre del tipo de presentacion del medicamento")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo Presentacion", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "Nombre del departamento")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPaisFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departamento_Pais_IdPaisFK",
                        column: x => x.IdPaisFK,
                        principalTable: "Pais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "Nombre de usuario")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, comment: "contraseña del usuario")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdRolFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Rol_IdRolFK",
                        column: x => x.IdRolFK,
                        principalTable: "Rol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Contacto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Numero = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "Numero de contacto")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoConFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacto_Tipo Contacto_IdTipoConFK",
                        column: x => x.IdTipoConFK,
                        principalTable: "Tipo Contacto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Medicamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "Nombre del medicamento")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Precio = table.Column<decimal>(type: "decimal(12,2)", nullable: false, comment: "Precio del medicamento"),
                    Stock = table.Column<int>(type: "int", maxLength: 999, nullable: false, comment: "Stock del medicamento"),
                    FechaVencimiento = table.Column<DateTime>(type: "datetime", nullable: false, comment: "Fecha de vencimiento del medicamento"),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "Descripcion del medicamento")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdCatFK = table.Column<int>(type: "int", nullable: false),
                    IdMarFK = table.Column<int>(type: "int", nullable: false),
                    Disponibilidad = table.Column<bool>(type: "tinyint(1)", nullable: false, comment: "Disponibilidad del medicamento"),
                    IdTipoPreFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medicamento_Categoria_IdCatFK",
                        column: x => x.IdCatFK,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Medicamento_Marca_IdMarFK",
                        column: x => x.IdMarFK,
                        principalTable: "Marca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Medicamento_Tipo Presentacion_IdTipoPreFK",
                        column: x => x.IdTipoPreFK,
                        principalTable: "Tipo Presentacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ciudad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "Nombre de la ciudad")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdDepFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ciudad_Departamento_IdDepFk",
                        column: x => x.IdDepFk,
                        principalTable: "Departamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Direccion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "Descripcion de la direccion")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdCiuFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direccion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Direccion_Ciudad_IdCiuFK",
                        column: x => x.IdCiuFK,
                        principalTable: "Ciudad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombres = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "Nombres del docto")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellidos = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "Apellidos del doctor")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdEspFK = table.Column<int>(type: "int", nullable: false),
                    IdTipoDocFK = table.Column<int>(type: "int", nullable: false),
                    Edad = table.Column<int>(type: "int", maxLength: 3, nullable: false, comment: "Edad del doctor"),
                    IdGenFK = table.Column<int>(type: "int", nullable: false),
                    IdTipoPerFK = table.Column<int>(type: "int", nullable: false),
                    IdDirFK = table.Column<int>(type: "int", nullable: false),
                    IdConFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctor_Contacto_IdConFK",
                        column: x => x.IdConFK,
                        principalTable: "Contacto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Doctor_Direccion_IdDirFK",
                        column: x => x.IdDirFK,
                        principalTable: "Direccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Doctor_Especializacion_IdEspFK",
                        column: x => x.IdEspFK,
                        principalTable: "Especializacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Doctor_Genero_IdGenFK",
                        column: x => x.IdGenFK,
                        principalTable: "Genero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Doctor_Tipo Documento_IdTipoDocFK",
                        column: x => x.IdTipoDocFK,
                        principalTable: "Tipo Documento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Doctor_Tipo Persona_IdTipoPerFK",
                        column: x => x.IdTipoPerFK,
                        principalTable: "Tipo Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Farmaceutico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombres = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "Nombres del farmaceutico")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellidos = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "Apellidos del farmaceutico")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoDocFK = table.Column<int>(type: "int", nullable: false),
                    Edad = table.Column<int>(type: "int", maxLength: 3, nullable: false, comment: "Edad del farmaceutico"),
                    IdGenFK = table.Column<int>(type: "int", nullable: false),
                    IdTipoPerFK = table.Column<int>(type: "int", nullable: false),
                    IdDirFK = table.Column<int>(type: "int", nullable: false),
                    IdConFK = table.Column<int>(type: "int", nullable: false),
                    IdCarFK = table.Column<int>(type: "int", nullable: false),
                    IdUserFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farmaceutico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Farmaceutico_Cargo_IdCarFK",
                        column: x => x.IdCarFK,
                        principalTable: "Cargo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Farmaceutico_Contacto_IdConFK",
                        column: x => x.IdConFK,
                        principalTable: "Contacto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Farmaceutico_Direccion_IdDirFK",
                        column: x => x.IdDirFK,
                        principalTable: "Direccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Farmaceutico_Genero_IdGenFK",
                        column: x => x.IdGenFK,
                        principalTable: "Genero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Farmaceutico_Tipo Documento_IdTipoDocFK",
                        column: x => x.IdTipoDocFK,
                        principalTable: "Tipo Documento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Farmaceutico_Tipo Persona_IdTipoPerFK",
                        column: x => x.IdTipoPerFK,
                        principalTable: "Tipo Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Farmaceutico_User_IdUserFK",
                        column: x => x.IdUserFK,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombres = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "Nombres del paciente")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellidos = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "Apellidos del paciente")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaNac = table.Column<DateTime>(type: "datetime", nullable: false, comment: "Fecha de nacimiento del paciente"),
                    IdGenFK = table.Column<int>(type: "int", nullable: false),
                    Edad = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false, comment: "Edad del paciente")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoDocFK = table.Column<int>(type: "int", nullable: false),
                    IdTipoPerFK = table.Column<int>(type: "int", nullable: false),
                    IdDirFK = table.Column<int>(type: "int", nullable: false),
                    IdConFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Paciente_Contacto_IdConFK",
                        column: x => x.IdConFK,
                        principalTable: "Contacto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Paciente_Direccion_IdDirFK",
                        column: x => x.IdDirFK,
                        principalTable: "Direccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Paciente_Genero_IdGenFK",
                        column: x => x.IdGenFK,
                        principalTable: "Genero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Paciente_Tipo Documento_IdTipoDocFK",
                        column: x => x.IdTipoDocFK,
                        principalTable: "Tipo Documento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Paciente_Tipo Persona_IdTipoPerFK",
                        column: x => x.IdTipoPerFK,
                        principalTable: "Tipo Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Proveedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombres = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "Nombres del proveedor")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellidos = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "Apellidos del proveedor")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoDocFK = table.Column<int>(type: "int", nullable: false),
                    Edad = table.Column<int>(type: "int", maxLength: 3, nullable: false, comment: "Edad del proveedor"),
                    IdGenFK = table.Column<int>(type: "int", nullable: false),
                    IdTipoPerFK = table.Column<int>(type: "int", nullable: false),
                    IdDirFK = table.Column<int>(type: "int", nullable: false),
                    IdConFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proveedor_Contacto_IdConFK",
                        column: x => x.IdConFK,
                        principalTable: "Contacto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proveedor_Direccion_IdDirFK",
                        column: x => x.IdDirFK,
                        principalTable: "Direccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proveedor_Genero_IdGenFK",
                        column: x => x.IdGenFK,
                        principalTable: "Genero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proveedor_Tipo Documento_IdTipoDocFK",
                        column: x => x.IdTipoDocFK,
                        principalTable: "Tipo Documento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proveedor_Tipo Persona_IdTipoPerFK",
                        column: x => x.IdTipoPerFK,
                        principalTable: "Tipo Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Formula",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdDocFK = table.Column<int>(type: "int", nullable: false),
                    IdPacFK = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false, comment: "Fecha de creacion de la formula"),
                    FechaExpiracion = table.Column<DateTime>(type: "datetime", nullable: false, comment: "Fecha de expiracion de la formula"),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "Descripcion de la formula")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formula", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Formula_Doctor_IdDocFK",
                        column: x => x.IdDocFK,
                        principalTable: "Doctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Formula_Paciente_IdPacFK",
                        column: x => x.IdPacFK,
                        principalTable: "Paciente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Compra Proveedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Precio = table.Column<decimal>(type: "decimal(12,2)", nullable: false, comment: "Precio total de lo que se vendio"),
                    Cantidad = table.Column<int>(type: "int", nullable: false, comment: "Cantidad que se vendio"),
                    IdMedFK = table.Column<int>(type: "int", nullable: false),
                    IdProvFK = table.Column<int>(type: "int", nullable: false),
                    IdFarFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compra Proveedor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compra Proveedor_Farmaceutico_IdFarFK",
                        column: x => x.IdFarFK,
                        principalTable: "Farmaceutico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Compra Proveedor_Medicamento_IdMedFK",
                        column: x => x.IdMedFK,
                        principalTable: "Medicamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Compra Proveedor_Proveedor_IdProvFK",
                        column: x => x.IdProvFK,
                        principalTable: "Proveedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false, comment: "Fecha de creacion de la factura"),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "Descripcion de la factura")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Valor = table.Column<decimal>(type: "decimal(10,2)", nullable: false, comment: "Valor total de la factura"),
                    Estado = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false, comment: "Estado de la factura")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cantidad = table.Column<int>(type: "int", maxLength: 7, nullable: false, comment: "Cantidad total de la factura"),
                    IdMedFK = table.Column<int>(type: "int", nullable: false),
                    IdFarFK = table.Column<int>(type: "int", nullable: false),
                    IdPacFK = table.Column<int>(type: "int", nullable: false),
                    IdForFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Factura_Farmaceutico_IdFarFK",
                        column: x => x.IdFarFK,
                        principalTable: "Farmaceutico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Factura_Formula_IdForFK",
                        column: x => x.IdForFK,
                        principalTable: "Formula",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Factura_Medicamento_IdMedFK",
                        column: x => x.IdMedFK,
                        principalTable: "Medicamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Factura_Paciente_IdPacFK",
                        column: x => x.IdPacFK,
                        principalTable: "Paciente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Registro Formula",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaRegistro = table.Column<DateTime>(type: "datetime", nullable: false, comment: "Fecha de registro de formulas x dia"),
                    IdForFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registro Formula", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registro Formula_Formula_IdForFK",
                        column: x => x.IdForFK,
                        principalTable: "Formula",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudad_IdDepFk",
                table: "Ciudad",
                column: "IdDepFk");

            migrationBuilder.CreateIndex(
                name: "IX_Compra Proveedor_IdFarFK",
                table: "Compra Proveedor",
                column: "IdFarFK");

            migrationBuilder.CreateIndex(
                name: "IX_Compra Proveedor_IdMedFK",
                table: "Compra Proveedor",
                column: "IdMedFK");

            migrationBuilder.CreateIndex(
                name: "IX_Compra Proveedor_IdProvFK",
                table: "Compra Proveedor",
                column: "IdProvFK");

            migrationBuilder.CreateIndex(
                name: "IX_Contacto_IdTipoConFK",
                table: "Contacto",
                column: "IdTipoConFK");

            migrationBuilder.CreateIndex(
                name: "IX_Departamento_IdPaisFK",
                table: "Departamento",
                column: "IdPaisFK");

            migrationBuilder.CreateIndex(
                name: "IX_Direccion_IdCiuFK",
                table: "Direccion",
                column: "IdCiuFK");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_IdConFK",
                table: "Doctor",
                column: "IdConFK");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_IdDirFK",
                table: "Doctor",
                column: "IdDirFK");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_IdEspFK",
                table: "Doctor",
                column: "IdEspFK");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_IdGenFK",
                table: "Doctor",
                column: "IdGenFK");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_IdTipoDocFK",
                table: "Doctor",
                column: "IdTipoDocFK");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_IdTipoPerFK",
                table: "Doctor",
                column: "IdTipoPerFK");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_IdFarFK",
                table: "Factura",
                column: "IdFarFK");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_IdForFK",
                table: "Factura",
                column: "IdForFK");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_IdMedFK",
                table: "Factura",
                column: "IdMedFK");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_IdPacFK",
                table: "Factura",
                column: "IdPacFK");

            migrationBuilder.CreateIndex(
                name: "IX_Farmaceutico_IdCarFK",
                table: "Farmaceutico",
                column: "IdCarFK");

            migrationBuilder.CreateIndex(
                name: "IX_Farmaceutico_IdConFK",
                table: "Farmaceutico",
                column: "IdConFK");

            migrationBuilder.CreateIndex(
                name: "IX_Farmaceutico_IdDirFK",
                table: "Farmaceutico",
                column: "IdDirFK");

            migrationBuilder.CreateIndex(
                name: "IX_Farmaceutico_IdGenFK",
                table: "Farmaceutico",
                column: "IdGenFK");

            migrationBuilder.CreateIndex(
                name: "IX_Farmaceutico_IdTipoDocFK",
                table: "Farmaceutico",
                column: "IdTipoDocFK");

            migrationBuilder.CreateIndex(
                name: "IX_Farmaceutico_IdTipoPerFK",
                table: "Farmaceutico",
                column: "IdTipoPerFK");

            migrationBuilder.CreateIndex(
                name: "IX_Farmaceutico_IdUserFK",
                table: "Farmaceutico",
                column: "IdUserFK");

            migrationBuilder.CreateIndex(
                name: "IX_Formula_IdDocFK",
                table: "Formula",
                column: "IdDocFK");

            migrationBuilder.CreateIndex(
                name: "IX_Formula_IdPacFK",
                table: "Formula",
                column: "IdPacFK");

            migrationBuilder.CreateIndex(
                name: "IX_Medicamento_IdCatFK",
                table: "Medicamento",
                column: "IdCatFK");

            migrationBuilder.CreateIndex(
                name: "IX_Medicamento_IdMarFK",
                table: "Medicamento",
                column: "IdMarFK");

            migrationBuilder.CreateIndex(
                name: "IX_Medicamento_IdTipoPreFK",
                table: "Medicamento",
                column: "IdTipoPreFK");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_IdConFK",
                table: "Paciente",
                column: "IdConFK");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_IdDirFK",
                table: "Paciente",
                column: "IdDirFK");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_IdGenFK",
                table: "Paciente",
                column: "IdGenFK");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_IdTipoDocFK",
                table: "Paciente",
                column: "IdTipoDocFK");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_IdTipoPerFK",
                table: "Paciente",
                column: "IdTipoPerFK");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedor_IdConFK",
                table: "Proveedor",
                column: "IdConFK");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedor_IdDirFK",
                table: "Proveedor",
                column: "IdDirFK");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedor_IdGenFK",
                table: "Proveedor",
                column: "IdGenFK");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedor_IdTipoDocFK",
                table: "Proveedor",
                column: "IdTipoDocFK");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedor_IdTipoPerFK",
                table: "Proveedor",
                column: "IdTipoPerFK");

            migrationBuilder.CreateIndex(
                name: "IX_Registro Formula_IdForFK",
                table: "Registro Formula",
                column: "IdForFK");

            migrationBuilder.CreateIndex(
                name: "IX_User_IdRolFK",
                table: "User",
                column: "IdRolFK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compra Proveedor");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "Registro Formula");

            migrationBuilder.DropTable(
                name: "Proveedor");

            migrationBuilder.DropTable(
                name: "Farmaceutico");

            migrationBuilder.DropTable(
                name: "Medicamento");

            migrationBuilder.DropTable(
                name: "Formula");

            migrationBuilder.DropTable(
                name: "Cargo");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Marca");

            migrationBuilder.DropTable(
                name: "Tipo Presentacion");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "Especializacion");

            migrationBuilder.DropTable(
                name: "Contacto");

            migrationBuilder.DropTable(
                name: "Direccion");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "Tipo Documento");

            migrationBuilder.DropTable(
                name: "Tipo Persona");

            migrationBuilder.DropTable(
                name: "Tipo Contacto");

            migrationBuilder.DropTable(
                name: "Ciudad");

            migrationBuilder.DropTable(
                name: "Departamento");

            migrationBuilder.DropTable(
                name: "Pais");
        }
    }
}
