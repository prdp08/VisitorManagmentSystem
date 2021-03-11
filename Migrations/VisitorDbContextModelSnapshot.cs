﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VisitorManagmentSystem.Data;

namespace VisitorManagmentSystem.Migrations
{
    [DbContext(typeof(VisitorDbContext))]
    partial class VisitorDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("VisitorManagmentSystem.Models.StaffNames", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VisitorCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("StaffNames");
                });

            modelBuilder.Entity("VisitorManagmentSystem.Models.Visitors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Business")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOut")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StaffNameId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StaffNameId");

                    b.ToTable("Visitor");
                });

            modelBuilder.Entity("VisitorManagmentSystem.Models.Visitors", b =>
                {
                    b.HasOne("VisitorManagmentSystem.Models.StaffNames", "StaffName")
                        .WithMany()
                        .HasForeignKey("StaffNameId");

                    b.Navigation("StaffName");
                });
#pragma warning restore 612, 618
        }
    }
}
