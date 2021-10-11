using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjectWork.Models
{
    public partial class ASPExcerciseContext : DbContext
    {
        public ASPExcerciseContext()
        {
        }

        public ASPExcerciseContext(DbContextOptions<ASPExcerciseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FoodItem> FoodItem { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderItem> OrderItem { get; set; }
        public virtual DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-PLG7HV2\\SQLEXPRESS;Database=ASPExcercise;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodItem>(entity =>
            {
                entity.Property(e => e.Desc).HasMaxLength(500);

                entity.Property(e => e.ImgSource).HasMaxLength(150);

                entity.Property(e => e.Title).HasMaxLength(100);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Customer).HasMaxLength(50);

                entity.HasOne(d => d.OrderItem)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.OrderItemId)
                    .HasConstraintName("FK_Order_OrderItem");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.HasIndex(e => e.ProductId)
                    .HasName("FK_ProductId")
                    .IsUnique();

                entity.HasOne(d => d.OrderNavigation)
                    .WithMany(p => p.OrderItemNavigation)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderItem_Order");

                entity.HasOne(d => d.Product)
                    .WithOne(p => p.OrderItem)
                    .HasForeignKey<OrderItem>(d => d.ProductId)
                    .HasConstraintName("FK_OrderItem_Product");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
