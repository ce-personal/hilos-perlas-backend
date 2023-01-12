﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nothing.Models;

#nullable disable

namespace Nothing.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230106200340_initial-migration")]
    partial class initialmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Nothing.Models.Gen.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RecordId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RecordId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Nothing.Models.Gen.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Nothing.Models.Gen.UserAdmin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserAdmin");
                });

            modelBuilder.Entity("Nothing.Models.Shared.File", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("FirstLevelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsItMainFile")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RecordId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SecondLevelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("StringFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ThirdLevelId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("FirstLevelId");

                    b.HasIndex("ProductId");

                    b.HasIndex("RecordId");

                    b.HasIndex("SecondLevelId");

                    b.HasIndex("ThirdLevelId");

                    b.ToTable("File");
                });

            modelBuilder.Entity("Nothing.Models.Shared.Score", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Score");
                });

            modelBuilder.Entity("Nothing.Models.Shop.CustomProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FirstLevelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ItemOrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SecondLevelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ThirdLevelId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("FirstLevelId");

                    b.HasIndex("ItemOrderId");

                    b.HasIndex("SecondLevelId");

                    b.HasIndex("ThirdLevelId");

                    b.ToTable("CustomProduct");
                });

            modelBuilder.Entity("Nothing.Models.Shop.ItemOrder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("ItemOrder");
                });

            modelBuilder.Entity("Nothing.Models.Shop.Level", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Level");
                });

            modelBuilder.Entity("Nothing.Models.Shop.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Ubication")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Nothing.Models.Shop.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CustomProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CustomProductId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid?>("RecordId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("UniquePiece")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CustomProductId1");

                    b.HasIndex("RecordId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Nothing.Models.Gen.Category", b =>
                {
                    b.HasOne("Nothing.Models.Gen.UserAdmin", "Record")
                        .WithMany()
                        .HasForeignKey("RecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Record");
                });

            modelBuilder.Entity("Nothing.Models.Shared.File", b =>
                {
                    b.HasOne("Nothing.Models.Shop.Level", "FirstLevel")
                        .WithMany()
                        .HasForeignKey("FirstLevelId");

                    b.HasOne("Nothing.Models.Shop.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("Nothing.Models.Gen.UserAdmin", "Record")
                        .WithMany()
                        .HasForeignKey("RecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nothing.Models.Shop.Level", "SecondLevel")
                        .WithMany()
                        .HasForeignKey("SecondLevelId");

                    b.HasOne("Nothing.Models.Shop.Level", "ThirdLevel")
                        .WithMany()
                        .HasForeignKey("ThirdLevelId");

                    b.Navigation("FirstLevel");

                    b.Navigation("Product");

                    b.Navigation("Record");

                    b.Navigation("SecondLevel");

                    b.Navigation("ThirdLevel");
                });

            modelBuilder.Entity("Nothing.Models.Shared.Score", b =>
                {
                    b.HasOne("Nothing.Models.Shop.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Nothing.Models.Shop.CustomProduct", b =>
                {
                    b.HasOne("Nothing.Models.Shop.Level", "FirstLevel")
                        .WithMany()
                        .HasForeignKey("FirstLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nothing.Models.Shop.ItemOrder", "ItemOrder")
                        .WithMany()
                        .HasForeignKey("ItemOrderId");

                    b.HasOne("Nothing.Models.Shop.Level", "SecondLevel")
                        .WithMany()
                        .HasForeignKey("SecondLevelId");

                    b.HasOne("Nothing.Models.Shop.Level", "ThirdLevel")
                        .WithMany()
                        .HasForeignKey("ThirdLevelId");

                    b.Navigation("FirstLevel");

                    b.Navigation("ItemOrder");

                    b.Navigation("SecondLevel");

                    b.Navigation("ThirdLevel");
                });

            modelBuilder.Entity("Nothing.Models.Shop.ItemOrder", b =>
                {
                    b.HasOne("Nothing.Models.Shop.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nothing.Models.Shop.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Nothing.Models.Shop.Level", b =>
                {
                    b.HasOne("Nothing.Models.Gen.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Nothing.Models.Shop.Order", b =>
                {
                    b.HasOne("Nothing.Models.Gen.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Nothing.Models.Shop.Product", b =>
                {
                    b.HasOne("Nothing.Models.Gen.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("Nothing.Models.Shop.CustomProduct", "CustomProduct")
                        .WithMany()
                        .HasForeignKey("CustomProductId1");

                    b.HasOne("Nothing.Models.Gen.UserAdmin", "Record")
                        .WithMany()
                        .HasForeignKey("RecordId");

                    b.Navigation("Category");

                    b.Navigation("CustomProduct");

                    b.Navigation("Record");
                });
#pragma warning restore 612, 618
        }
    }
}