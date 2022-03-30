﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MobileShop.Data;

#nullable disable

namespace MobileShop.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MobileShop.Domain.Additionally", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("BatteryCapacity")
                        .HasColumnType("float");

                    b.Property<string>("BatteryType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChargerType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Equipment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Additionally");
                });

            modelBuilder.Entity("MobileShop.Domain.Brand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("MobileShop.Domain.Connection", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Interfaces")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StandardsSupport")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Connection");
                });

            modelBuilder.Entity("MobileShop.Domain.ImageModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ImageModel");
                });

            modelBuilder.Entity("MobileShop.Domain.MainCharacters", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Dimensions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HasFingerPrintScanner")
                        .HasColumnType("int");

                    b.Property<int>("IsDual")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OSVersion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SimCardType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfFrame")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("MainCharacters");
                });

            modelBuilder.Entity("MobileShop.Domain.MemoryAndProcessor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CPU")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfCores")
                        .HasColumnType("int");

                    b.Property<string>("RAM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ROM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoProcessor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MemoryAndProcessor");
                });

            modelBuilder.Entity("MobileShop.Domain.MultimediaFeatures", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AudioSupport")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cameras")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Flash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrontCamera")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfCameras")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MultimediaFeatures");
                });

            modelBuilder.Entity("MobileShop.Domain.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AdditionallyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BrandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ConnectionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MainCharactersId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MemoryAndProcessorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MultimediaFeaturesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ScreenCharactersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AdditionallyId");

                    b.HasIndex("ConnectionId");

                    b.HasIndex("MainCharactersId");

                    b.HasIndex("MemoryAndProcessorId");

                    b.HasIndex("MultimediaFeaturesId");

                    b.HasIndex("ScreenCharactersId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MobileShop.Domain.ScreenCharacters", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AspectRatio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Diagonal")
                        .HasColumnType("float");

                    b.Property<string>("ImageSize")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ScreenHZ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ScreenType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ScreenCharacters");
                });

            modelBuilder.Entity("MobileShop.Domain.ImageModel", b =>
                {
                    b.HasOne("MobileShop.Domain.Product", null)
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MobileShop.Domain.Product", b =>
                {
                    b.HasOne("MobileShop.Domain.Additionally", "Additionally")
                        .WithMany()
                        .HasForeignKey("AdditionallyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MobileShop.Domain.Connection", "Connection")
                        .WithMany()
                        .HasForeignKey("ConnectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MobileShop.Domain.MainCharacters", "MainCharacters")
                        .WithMany()
                        .HasForeignKey("MainCharactersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MobileShop.Domain.MemoryAndProcessor", "MemoryAndProcessor")
                        .WithMany()
                        .HasForeignKey("MemoryAndProcessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MobileShop.Domain.MultimediaFeatures", "MultimediaFeatures")
                        .WithMany()
                        .HasForeignKey("MultimediaFeaturesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MobileShop.Domain.ScreenCharacters", "ScreenCharacters")
                        .WithMany()
                        .HasForeignKey("ScreenCharactersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Additionally");

                    b.Navigation("Connection");

                    b.Navigation("MainCharacters");

                    b.Navigation("MemoryAndProcessor");

                    b.Navigation("MultimediaFeatures");

                    b.Navigation("ScreenCharacters");
                });

            modelBuilder.Entity("MobileShop.Domain.Product", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
