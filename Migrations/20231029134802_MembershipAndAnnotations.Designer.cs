﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyTermProject.Models;

#nullable disable

namespace MyTermProject.Migrations
{
    [DbContext(typeof(CatalogContext))]
    [Migration("20231029134802_MembershipAndAnnotations")]
    partial class MembershipAndAnnotations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MyTermProject.Models.Books", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("BookFormat")
                        .HasColumnType("int");

                    b.Property<string>("BookTitle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("GenreId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AuthorName = "JK Rowling",
                            BookFormat = 2,
                            BookTitle = "Harry Potter and the Sorcerer's Stone",
                            GenreId = 1
                        },
                        new
                        {
                            ID = 2,
                            AuthorName = "James Clear",
                            BookFormat = 0,
                            BookTitle = "Atomic Habits: An Easy & Proven Way to Build Good Habits & Break Bad Ones",
                            GenreId = 2
                        },
                        new
                        {
                            ID = 3,
                            AuthorName = "Kristin Hannah",
                            BookTitle = "Night Road",
                            GenreId = 3
                        });
                });

            modelBuilder.Entity("MyTermProject.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            Name = "Fantasy"
                        },
                        new
                        {
                            GenreId = 2,
                            Name = "Self-Help"
                        },
                        new
                        {
                            GenreId = 3,
                            Name = "Fiction"
                        });
                });

            modelBuilder.Entity("MyTermProject.Models.Membership", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("First Name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Last Name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Zipcode");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Memberships");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "",
                            City = "",
                            ConfirmPassword = "",
                            Country = "",
                            Email = "johnR@gmail.com",
                            FirstName = "John",
                            LastName = "Robinson",
                            Password = "multi!Master21",
                            PostalCode = "",
                            State = "",
                            Username = "JoRobinson"
                        },
                        new
                        {
                            ID = 2,
                            Address = "",
                            City = "",
                            ConfirmPassword = "",
                            Country = "",
                            Email = "sallyS@gmail.com",
                            FirstName = "Sally",
                            LastName = "Smith",
                            Password = "yellow&Spot46",
                            PostalCode = "",
                            State = "",
                            Username = "SaSmith"
                        },
                        new
                        {
                            ID = 3,
                            Address = "",
                            City = "",
                            ConfirmPassword = "",
                            Country = "",
                            Email = "rogerJ@gmail.com",
                            FirstName = "Roger",
                            LastName = "Johnson",
                            Password = "blue*Flip62",
                            PostalCode = "",
                            State = "",
                            Username = "RoJohnson"
                        });
                });

            modelBuilder.Entity("MyTermProject.Models.Books", b =>
                {
                    b.HasOne("MyTermProject.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });
#pragma warning restore 612, 618
        }
    }
}