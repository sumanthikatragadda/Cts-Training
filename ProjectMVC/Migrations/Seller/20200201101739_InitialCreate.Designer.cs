﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectMVC.Models;

namespace ProjectMVC.Migrations.Seller
{
    [DbContext(typeof(SellerContext))]
    [Migration("20200201101739_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjectMVC.Models.Seller", b =>
                {
                    b.Property<int>("Sid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Companyname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Contactno")
                        .HasColumnType("int");

                    b.Property<string>("Photopath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Saddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Semail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Spassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Sid");

                    b.ToTable("Sellers");
                });
#pragma warning restore 612, 618
        }
    }
}
