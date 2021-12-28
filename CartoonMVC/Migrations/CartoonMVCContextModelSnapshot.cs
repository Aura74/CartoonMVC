﻿// <auto-generated />
using System;
using CartoonMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CartoonMVC.Migrations
{
    [DbContext(typeof(CartoonMVCContext))]
    partial class CartoonMVCContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CartoonMVC.Models.Monster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("DegreeOfDanger")
                        .HasColumnType("int");

                    b.Property<string>("Element")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("IQ")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Information")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Naughtiness")
                        .HasColumnType("int");

                    b.Property<DateTime>("SeenLastTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.Property<string>("Warning")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Weaknesses")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Monster");
                });
#pragma warning restore 612, 618
        }
    }
}
