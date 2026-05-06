using System;
using System.Collections.Generic;
using KRSHGEOG.Entities;
using Microsoft.EntityFrameworkCore;

namespace KRSHGEOG.DataAccess;

public partial class FerreteriaIndustrialContext : DbContext
{
    public FerreteriaIndustrialContext()
    {
    }

    public FerreteriaIndustrialContext(DbContextOptions<FerreteriaIndustrialContext> options)
        : base(options)
    {
    }

    public virtual DbSet<HardwareProduct> HardwareProducts { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<ToolBrand> ToolBrands { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=FerreteriaIndustrial;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HardwareProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Hardware__3214EC07E6B54A55");

            entity.Property(e => e.ProductName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SalePrice).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.ToolBrand).WithMany(p => p.HardwareProducts)
                .HasForeignKey(d => d.ToolBrandId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HardwareP__ToolB__5165187F");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Roles__3214EC0752A2CEA5");

            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ToolBrand>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ToolBran__3214EC07BC543FFC");

            entity.Property(e => e.BrandName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC0765096000");

            entity.Property(e => e.PasswordHash)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Users__RoleId__4CA06362");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
