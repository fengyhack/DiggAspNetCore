using HaiAdmin.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace HaiAdmin.Migrations
{
    [DbContext(typeof(HaiDbContext))]
    partial class HaiDbContextSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("HaiAdmin.Models.UserInfo", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id")
                    .HasColumnType("integer")
                    .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying(64)")
                    .HasMaxLength(64);

                b.Property<string>("Token")
                   .IsRequired()
                   .HasColumnName("token")
                   .HasColumnType("character varying");

                b.Property<string>("Role")
                    .IsRequired()
                    .HasColumnName("role")
                    .HasColumnType("character varying");

                b.HasKey("Id");

                b.ToTable("UserInfo");
            });

            modelBuilder.Entity("HaiAdmin.Models.InstrumentInfo", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id")
                    .HasColumnType("integer")
                    .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                b.Property<string>("Guid")
                    .IsRequired()
                    .HasColumnName("guid")
                    .HasColumnType("character varying(64)")
                    .HasMaxLength(64);

                b.Property<string>("Type")
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("character varying");

                b.Property<string>("Model")
                    .IsRequired()
                    .HasColumnName("model")
                    .HasColumnType("character varying");

                b.Property<string>("Key")
                    .IsRequired()
                    .HasColumnName("key")
                    .HasColumnType("character varying");

                b.HasKey("Id");

                b.ToTable("InstrumentInfo");
            });

            modelBuilder.Entity("HaiAdmin.Models.ModelInfo", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id")
                    .HasColumnType("integer")
                    .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                b.Property<string>("Type")
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("character varying");

                b.Property<string>("Models")
                    .IsRequired()
                    .HasColumnName("models")
                    .HasColumnType("character varying");

                b.HasKey("Id");

                b.ToTable("ModelInfo");
            });

            modelBuilder.Entity("HaiAdmin.Models.TemplateInfo", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id")
                    .HasColumnType("integer")
                    .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                b.Property<string>("Type")
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("character varying");

                b.Property<string>("Model")
                    .IsRequired()
                    .HasColumnName("model")
                    .HasColumnType("character varying");

                b.Property<string>("Key")
                    .IsRequired()
                    .HasColumnName("key")
                    .HasColumnType("character varying");

                b.HasKey("Id");

                b.ToTable("TemplateInfo");
            });

            modelBuilder.Entity("HaiAdmin.Models.ConfigInfo", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id")
                    .HasColumnType("integer")
                    .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                b.Property<string>("Type")
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("character varying");

                b.Property<string>("Model")
                    .IsRequired()
                    .HasColumnName("model")
                    .HasColumnType("character varying");

                b.Property<string>("Key")
                    .IsRequired()
                    .HasColumnName("key")
                    .HasColumnType("character varying");

                b.HasKey("Id");

                b.ToTable("ConfigInfo");
            });

            modelBuilder.Entity("HaiAdmin.Models.ScriptInfo", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id")
                    .HasColumnType("integer")
                    .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                b.Property<string>("Type")
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("character varying");

                b.Property<string>("Model")
                    .IsRequired()
                    .HasColumnName("model")
                    .HasColumnType("character varying");

                b.Property<string>("Workflow")
                    .IsRequired()
                    .HasColumnName("workflow")
                    .HasColumnType("character varying");

                b.Property<string>("Key")
                    .IsRequired()
                    .HasColumnName("key")
                    .HasColumnType("character varying");

                b.HasKey("Id");

                b.ToTable("ScriptInfo");
            });

            modelBuilder.Entity("HaiAdmin.Models.ReportInfo", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id")
                    .HasColumnType("integer")
                    .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                b.Property<string>("Guid")
                    .IsRequired()
                    .HasColumnName("guid")
                    .HasColumnType("character varying(64)")
                    .HasMaxLength(64);

                b.Property<string>("Key")
                    .IsRequired()
                    .HasColumnName("key")
                    .HasColumnType("character varying");

                b.HasKey("Id");

                b.ToTable("ReportInfo");
            });

            modelBuilder.Entity("HaiAdmin.Models.FileMetaInfo", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id")
                    .HasColumnType("integer")
                    .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                b.Property<string>("Key")
                    .IsRequired()
                    .HasColumnName("key")
                    .HasColumnType("character varying");

                b.Property<string>("FileName")
                    .IsRequired()
                    .HasColumnName("filename")
                    .HasColumnType("character varying");

                b.Property<bool?>("IsZipped")
                   .IsRequired()
                   .HasColumnName("zipped")
                   .HasColumnType("boolean");

                b.Property<string>("Location")
                    .IsRequired()
                    .HasColumnName("location")
                    .HasColumnType("character varying");

                b.HasKey("Id");

                b.ToTable("FileMetaInfo");
            });
        }
    }
}
