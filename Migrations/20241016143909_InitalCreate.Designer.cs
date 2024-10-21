﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductsAPI.Models;

#nullable disable

namespace ProductsAPI.Migrations
{
    [DbContext(typeof(ProductsContext))]
    [Migration("20241016143909_InitalCreate")]
    partial class InitalCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("ProductsAPI.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            IsActive = true,
                            Price = 40000m,
                            ProductName = "IPhone 14"
                        },
                        new
                        {
                            ProductId = 2,
                            IsActive = true,
                            Price = 50000m,
                            ProductName = "IPhone 15"
                        },
                        new
                        {
                            ProductId = 3,
                            IsActive = true,
                            Price = 60000m,
                            ProductName = "IPhone 16"
                        },
                        new
                        {
                            ProductId = 4,
                            IsActive = true,
                            Price = 70000m,
                            ProductName = "IPhone 17"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
