﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories;

#nullable disable

namespace Kutuphane.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20230919121956_KiralamaDb")]
    partial class KiralamaDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Models.Kiralama", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("KitapId")
                        .HasColumnType("int");

                    b.Property<int>("OgrenciId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KitapId");

                    b.ToTable("Kiralamalar");
                });

            modelBuilder.Entity("Entities.Models.Kitap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Fiyat")
                        .HasColumnType("float");

                    b.Property<string>("KitapAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KitapTuruId")
                        .HasColumnType("int");

                    b.Property<string>("ResimUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tanim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yazar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KitapTuruId");

                    b.ToTable("Kitaplar");
                });

            modelBuilder.Entity("Entities.Models.KitapTuru", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("KitapTurleri");
                });

            modelBuilder.Entity("Entities.Models.Kiralama", b =>
                {
                    b.HasOne("Entities.Models.Kitap", "Kitap")
                        .WithMany()
                        .HasForeignKey("KitapId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kitap");
                });

            modelBuilder.Entity("Entities.Models.Kitap", b =>
                {
                    b.HasOne("Entities.Models.KitapTuru", "KitapTuru")
                        .WithMany()
                        .HasForeignKey("KitapTuruId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KitapTuru");
                });
#pragma warning restore 612, 618
        }
    }
}
