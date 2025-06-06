﻿// <auto-generated />
using System;
using ListedLinks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ListedLinks.Migrations
{
    [DbContext(typeof(ListedLinksContext))]
    [Migration("20250529233735_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.5");

            modelBuilder.Entity("ListedLinks.Models.Book", b =>
                {
                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<string>("Blurb")
                        .HasColumnType("TEXT");

                    b.Property<string>("GenreName")
                        .HasColumnType("TEXT");

                    b.HasKey("Title", "Author");

                    b.HasIndex("GenreName");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("ListedLinks.Models.Comment", b =>
                {
                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Text", "CreatedAt");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("ListedLinks.Models.Genre", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("ListedLinks.Models.IPAddressString", b =>
                {
                    b.Property<string>("IPAddress")
                        .HasColumnType("TEXT");

                    b.HasKey("IPAddress");

                    b.ToTable("IPAddressStrings");
                });

            modelBuilder.Entity("ListedLinks.Models.ListedLink", b =>
                {
                    b.Property<int>("ListedLinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("ListedLinkId");

                    b.ToTable("ListedLinks");
                });

            modelBuilder.Entity("ListedLinks.Models.Book", b =>
                {
                    b.HasOne("ListedLinks.Models.Genre", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("GenreName");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("ListedLinks.Models.Genre", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
