﻿// <auto-generated />
using System;
using AbalfadhlTV.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AbalfadhlTV.Persistence.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220505172951_update")]
    partial class update
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AbalfadhlTV.Domain.ImamzadehaAgg.CitiesImamzadeh", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("CountryId")
                        .HasColumnType("bigint");

                    b.Property<long?>("CountryImamzadehId")
                        .HasColumnType("bigint");

                    b.Property<string>("HashCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RemoveTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CountryImamzadehId");

                    b.ToTable("CitiesImamzadehs");
                });

            modelBuilder.Entity("AbalfadhlTV.Domain.ImamzadehaAgg.CountryImamzadeh", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("HashCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RemoveTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("CountriesImamzadehs");
                });

            modelBuilder.Entity("AbalfadhlTV.Domain.ImamzadehaAgg.ItemsImamzadeh", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long?>("CitiesImamzadehId")
                        .HasColumnType("bigint");

                    b.Property<long>("CityId")
                        .HasColumnType("bigint");

                    b.Property<string>("HashCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RemoveTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CitiesImamzadehId");

                    b.ToTable("ItemsImamzadehs");
                });

            modelBuilder.Entity("AbalfadhlTV.Domain.ImamzadehaAgg.CitiesImamzadeh", b =>
                {
                    b.HasOne("AbalfadhlTV.Domain.ImamzadehaAgg.CountryImamzadeh", "CountryImamzadeh")
                        .WithMany("CitiesImamzadeh")
                        .HasForeignKey("CountryImamzadehId");

                    b.Navigation("CountryImamzadeh");
                });

            modelBuilder.Entity("AbalfadhlTV.Domain.ImamzadehaAgg.ItemsImamzadeh", b =>
                {
                    b.HasOne("AbalfadhlTV.Domain.ImamzadehaAgg.CitiesImamzadeh", "CitiesImamzadeh")
                        .WithMany("ItemsImamzadeh")
                        .HasForeignKey("CitiesImamzadehId");

                    b.Navigation("CitiesImamzadeh");
                });

            modelBuilder.Entity("AbalfadhlTV.Domain.ImamzadehaAgg.CitiesImamzadeh", b =>
                {
                    b.Navigation("ItemsImamzadeh");
                });

            modelBuilder.Entity("AbalfadhlTV.Domain.ImamzadehaAgg.CountryImamzadeh", b =>
                {
                    b.Navigation("CitiesImamzadeh");
                });
#pragma warning restore 612, 618
        }
    }
}
