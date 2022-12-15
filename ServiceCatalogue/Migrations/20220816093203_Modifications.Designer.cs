﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServiceCatalogue.Model;

namespace ServiceCatalogue.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220816093203_Modifications")]
    partial class Modifications
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ServiceCatalogue.Model.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppRole");
                });

            modelBuilder.Entity("ServiceCatalogue.Model.ServerAsset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Active")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("Sql")
                        .HasColumnType("int");

                    b.Property<int?>("SystemAssetId")
                        .HasColumnType("int");

                    b.Property<int>("Web")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SystemAssetId");

                    b.ToTable("ServerAsset");
                });

            modelBuilder.Entity("ServiceCatalogue.Model.SystemAsset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("LastDeployed")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sql")
                        .HasColumnType("int");

                    b.Property<int>("Web")
                        .HasColumnType("int");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wiki")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SystemAsset");
                });

            modelBuilder.Entity("ServiceCatalogue.Model.ServerAsset", b =>
                {
                    b.HasOne("ServiceCatalogue.Model.SystemAsset", "SystemAsset")
                        .WithMany("ServerAssets")
                        .HasForeignKey("SystemAssetId");
                });
#pragma warning restore 612, 618
        }
    }
}
