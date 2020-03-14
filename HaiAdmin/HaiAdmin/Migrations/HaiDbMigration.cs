using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace HaiAdmin.Migrations
{
    public partial class HaiDbMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "UserInfo",
               columns: table => new
               {
                   id = table.Column<int>(nullable: false).Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                   name = table.Column<string>(maxLength: 64, nullable: false),
                   token = table.Column<string>(type: "character varying", nullable: false),
                   role = table.Column<string>(type: "character varying", nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_UserInfo", x => x.id);
               });

            migrationBuilder.CreateTable(
                name: "InstrumentInfo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false).Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    guid = table.Column<string>(maxLength: 64, nullable: false),
                    type = table.Column<string>(type: "character varying", nullable: false),
                    model = table.Column<string>(type: "character varying", nullable: false),
                    key = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstrumentInfo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ModelInfo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false).Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    type = table.Column<string>(type: "character varying", nullable: false),
                    models = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelInfo", x => x.id);
                });           

            migrationBuilder.CreateTable(
                name: "TemplateInfo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false).Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    type = table.Column<string>(type: "character varying", nullable: false),
                    model = table.Column<string>(type: "character varying", nullable: false),
                    key = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateInfo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ConfigInfo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false).Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    type = table.Column<string>(type: "character varying", nullable: false),
                    model = table.Column<string>(type: "character varying", nullable: false),
                    key = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigInfo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ScriptInfo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false).Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    type = table.Column<string>(type: "character varying", nullable: false),
                    model = table.Column<string>(type: "character varying", nullable: false),
                    workflow = table.Column<string>(type: "character varying", nullable: false),
                    key = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScriptInfo", x => x.id);
                });

            migrationBuilder.CreateTable(
               name: "ReportInfo",
               columns: table => new
               {
                   id = table.Column<int>(nullable: false).Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                   guid = table.Column<string>(maxLength: 64, nullable: false),
                   key = table.Column<string>(type: "character varying", nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_ReportInfo", x => x.id);
               });

            migrationBuilder.CreateTable(
                name: "FileMetaInfo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false).Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    key = table.Column<string>(type: "character varying", nullable: false),
                    filename = table.Column<string>(type: "character varying", nullable: false),
                    zipped = table.Column<bool>(nullable: false),
                    location = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileMetaInfo", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "UserInfo");
            migrationBuilder.DropTable(name: "InstrumentInfo");
            migrationBuilder.DropTable(name: "ModelInfo");
            migrationBuilder.DropTable(name: "TemplateInfo");
            migrationBuilder.DropTable(name: "ConfigInfo");
            migrationBuilder.DropTable(name: "ScriptInfo");
            migrationBuilder.DropTable(name: "ReportInfo");
            migrationBuilder.DropTable(name: "FileMetaInfo");
        }
    }
}
