﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VP_7;

#nullable disable

namespace VP_7.Migrations
{
    [DbContext(typeof(VideoStoreContext))]
    [Migration("20220307161409_Add_Agency_Name")]
    partial class Add_Agency_Name
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AuthorVideoTape", b =>
                {
                    b.Property<int>("AuthorsId")
                        .HasColumnType("int");

                    b.Property<int>("TapesId")
                        .HasColumnType("int");

                    b.HasKey("AuthorsId", "TapesId");

                    b.HasIndex("TapesId");

                    b.ToTable("AuthorVideoTape");
                });

            modelBuilder.Entity("VP_7.Agency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DirectorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Agencies");
                });

            modelBuilder.Entity("VP_7.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AgencyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PhotoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AgencyId");

                    b.HasIndex("PhotoId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("VP_7.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte[]>("Data")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("VP_7.VideoTape", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RTFText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RecievementDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("RecordDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan?>("RecordLength")
                        .HasColumnType("time");

                    b.Property<string>("RecordType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tapes");
                });

            modelBuilder.Entity("AuthorVideoTape", b =>
                {
                    b.HasOne("VP_7.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VP_7.VideoTape", null)
                        .WithMany()
                        .HasForeignKey("TapesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VP_7.Author", b =>
                {
                    b.HasOne("VP_7.Agency", "Agency")
                        .WithMany("Authors")
                        .HasForeignKey("AgencyId");

                    b.HasOne("VP_7.Photo", "Photo")
                        .WithMany()
                        .HasForeignKey("PhotoId");

                    b.Navigation("Agency");

                    b.Navigation("Photo");
                });

            modelBuilder.Entity("VP_7.Agency", b =>
                {
                    b.Navigation("Authors");
                });
#pragma warning restore 612, 618
        }
    }
}