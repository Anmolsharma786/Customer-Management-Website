﻿// <auto-generated />
using CRUD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUD.Migrations.Customer
{
    [DbContext(typeof(CustomerContext))]
    [Migration("20200225192552_Customer")]
    partial class Customer
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CRUD.Models.Customers", b =>
                {
                    b.Property<int>("customerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProjectId")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("country")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("fname")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("lname")
                        .HasColumnType("varchar(10)");

                    b.HasKey("customerId");

                    b.ToTable("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}
