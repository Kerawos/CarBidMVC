﻿// <auto-generated />
using System;
using CarBidMVC.CarDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarBidMVC.Migrations
{
    [DbContext(typeof(CarDbContext))]
    partial class CarBidDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("CarBidMVC.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Damaged")
                        .HasColumnType("bit");

                    b.Property<int?>("ImageMiniId")
                        .HasColumnType("int");

                    b.Property<string>("Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkToAuction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeAuctionEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeAuctionStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ImageMiniId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CarBidMVC.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CarId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("CarBidMVC.Models.Car", b =>
                {
                    b.HasOne("CarBidMVC.Models.Image", "ImageMini")
                        .WithMany()
                        .HasForeignKey("ImageMiniId");

                    b.Navigation("ImageMini");
                });

            modelBuilder.Entity("CarBidMVC.Models.Image", b =>
                {
                    b.HasOne("CarBidMVC.Models.Car", null)
                        .WithMany("Images")
                        .HasForeignKey("CarId");
                });

            modelBuilder.Entity("CarBidMVC.Models.Car", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
