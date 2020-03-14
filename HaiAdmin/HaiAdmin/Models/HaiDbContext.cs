using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HaiAdmin.Models
{
    public partial class HaiDbContext : DbContext
    {
        public bool CanConnect { get; private set; }

        public HaiDbContext()
        {
        }

        public HaiDbContext(DbContextOptions<HaiDbContext> options)
            : base(options)
        {
            CanConnect = Database.CanConnect();
        }

        public virtual DbSet<UserInfo> Users { get; set; }
        
        public virtual DbSet<InstrumentInfo> Instruments { get; set; }
       
        public virtual DbSet<ModelInfo> ProductModels { get; set; }
        
        public virtual DbSet<TemplateInfo> Templates { get; set; }

        public virtual DbSet<ConfigInfo> Configs { get; set; }

        public virtual DbSet<ScriptInfo> Scripts { get; set; }

        public virtual DbSet<ReportInfo> Reports { get; set; }
        
        public virtual DbSet<FileMetaInfo> FileMetas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Name).HasColumnName("name").HasMaxLength(64);
                entity.Property(e => e.Token).HasColumnName("token").HasColumnType("character varying");
                entity.Property(e => e.Role).HasColumnName("role").HasColumnType("character varying");
            });

            modelBuilder.Entity<InstrumentInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Guid).HasColumnName("guid").HasMaxLength(64);
                entity.Property(e => e.Type).HasColumnName("type").HasColumnType("character varying");
                entity.Property(e => e.Model).HasColumnName("model").HasColumnType("character varying");
                entity.Property(e => e.Key).HasColumnName("key").HasColumnType("character varying");
            });

            modelBuilder.Entity<ModelInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Type).HasColumnName("type").HasColumnType("character varying");
                entity.Property(e => e.Models).HasColumnName("models").HasColumnType("character varying");
            });

            modelBuilder.Entity<TemplateInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Type).HasColumnName("type").HasColumnType("character varying");
                entity.Property(e => e.Model).HasColumnName("model").HasColumnType("character varying");
                entity.Property(e => e.Key).HasColumnName("key").HasColumnType("character varying");
            });

            modelBuilder.Entity<ConfigInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Type).HasColumnName("type").HasColumnType("character varying");
                entity.Property(e => e.Model).HasColumnName("model").HasColumnType("character varying");
                entity.Property(e => e.Key).HasColumnName("key").HasColumnType("character varying");
            });

            modelBuilder.Entity<ScriptInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Type).HasColumnName("type").HasColumnType("character varying");
                entity.Property(e => e.Model).HasColumnName("model").HasColumnType("character varying");
                entity.Property(e => e.Workflow).HasColumnName("workflow").HasColumnType("character varying");
                entity.Property(e => e.Key).HasColumnName("key").HasColumnType("character varying");
            });

            modelBuilder.Entity<ReportInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Guid).HasColumnName("guid").HasMaxLength(64);
                entity.Property(e => e.Key).HasColumnName("key").HasColumnType("character varying");
            });

            modelBuilder.Entity<FileMetaInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Key).HasColumnName("key").HasColumnType("character varying");
                entity.Property(e => e.FileName).HasColumnName("filename").HasColumnType("character varying");
                entity.Property(e => e.IsZipped).HasColumnName("zipped");                
                entity.Property(e => e.Location).HasColumnName("location").HasColumnType("character varying");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
