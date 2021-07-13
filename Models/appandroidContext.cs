using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace animaliasAPI.Models
{
    public partial class appandroidContext : DbContext
    {
        public appandroidContext()
        {
        }

        public appandroidContext(DbContextOptions<appandroidContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Breed> Breeds { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }
        public virtual DbSet<Updatenotification> Updatenotifications { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost; port=3305; database=appandroid; user=root; password=53355335;");
               
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>(entity =>
            {
                entity.HasKey(e => e.Idbrand)
                    .HasName("PRIMARY");

                entity.ToTable("brand");

                entity.Property(e => e.Idbrand).HasColumnName("idbrand");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Breed>(entity =>
            {
                entity.HasKey(e => e.IdBreed)
                    .HasName("PRIMARY");

                entity.ToTable("breed");

                entity.Property(e => e.IdBreed).HasColumnName("idBreed");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.IdProduct)
                    .HasName("PRIMARY");

                entity.ToTable("product");

                entity.Property(e => e.IdProduct).HasColumnName("idProduct");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.Description)
                    .HasMaxLength(45)
                    .HasColumnName("description");

                entity.Property(e => e.IdBrand)
                    .HasColumnType("int(10) unsigned zerofill")
                    .HasColumnName("idBrand");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("name");

                entity.Property(e => e.PhotoId)
                    .HasMaxLength(45)
                    .HasColumnName("photoId");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(10,0)")
                    .HasColumnName("precio");
            });

            modelBuilder.Entity<Promotion>(entity =>
            {
                entity.HasKey(e => e.IdPromo)
                    .HasName("PRIMARY");

                entity.ToTable("promotion");

                entity.Property(e => e.IdPromo)
                    .HasColumnType("int unsigned")
                    .HasColumnName("idPromo");

                entity.Property(e => e.FinishPromo).HasColumnName("finishPromo");

                entity.Property(e => e.Image)
                    .HasMaxLength(45)
                    .HasColumnName("image");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("name");

                entity.Property(e => e.StarPromo).HasColumnName("starPromo");
            });

            modelBuilder.Entity<Updatenotification>(entity =>
            {
                entity.HasKey(e => e.IdUpdatenotification)
                    .HasName("PRIMARY");

                entity.ToTable("updatenotification");

                entity.HasIndex(e => e.IdUser, "idUser_idx");

                entity.Property(e => e.IdUpdatenotification).HasColumnName("idUpdatenotification");

                entity.Property(e => e.CountDays).HasColumnName("countDays");

                entity.Property(e => e.DateUpdate).HasColumnName("dateUpdate");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Updatenotifications)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("idUser");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PRIMARY");

                entity.ToTable("user");

                entity.HasIndex(e => e.IdBrand, "idBrand_idx");

                entity.HasIndex(e => e.IdBreed, "idBreed_idx");

                entity.HasIndex(e => new { e.IdProduct, e.IdBreed, e.IdBrand }, "idProduct_idx");

                entity.HasIndex(e => new { e.IdBreed, e.IdBrand, e.IdProduct }, "idProduct_idx1");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.Address)
                    .HasMaxLength(45)
                    .HasColumnName("address");

                entity.Property(e => e.DateStart)
                    .HasMaxLength(45)
                    .HasColumnName("dateStart");

                entity.Property(e => e.IdBrand).HasColumnName("idBrand");

                entity.Property(e => e.IdBreed).HasColumnName("idBreed");

                entity.Property(e => e.IdProduct).HasColumnName("idProduct");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("mail");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(45)
                    .HasColumnName("password");

                entity.Property(e => e.Pet)
                    .HasMaxLength(45)
                    .HasColumnName("pet");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("telephone");

                entity.HasOne(d => d.IdBrandNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.IdBrand)
                    .HasConstraintName("idBrand");

                entity.HasOne(d => d.IdBreedNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.IdBreed)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("idBreed");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.IdProduct)
                    .HasConstraintName("idProduct");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
