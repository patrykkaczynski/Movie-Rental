﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieRental.Infrastructure.Persistence;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MovieRental.Infrastructure.Migrations
{
    [DbContext(typeof(MovieRentalDbContext))]
    [Migration("20230723083755_Add_DateOnly_For_ReleaseDate")]
    partial class Add_DateOnly_For_ReleaseDate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MovieRental.Domain.Entities.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Genre")
                        .HasColumnType("text");

                    b.Property<bool>("IsRented")
                        .HasColumnType("boolean");

                    b.Property<string>("RegionOfOrigin")
                        .HasColumnType("text");

                    b.Property<DateOnly?>("ReleaseDate")
                        .HasColumnType("date");

                    b.Property<int>("RunTimeMin")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MovieRental.Domain.Entities.Response", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("NumberOfDislikes")
                        .HasColumnType("integer");

                    b.Property<int>("NumberOfLikes")
                        .HasColumnType("integer");

                    b.Property<Guid>("ReviewId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ReviewId");

                    b.ToTable("Response");
                });

            modelBuilder.Entity("MovieRental.Domain.Entities.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<Guid>("MovieId")
                        .HasColumnType("uuid");

                    b.Property<int>("NumberOfDislikes")
                        .HasColumnType("integer");

                    b.Property<int>("NumberOfLikes")
                        .HasColumnType("integer");

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("MovieRental.Domain.Entities.Response", b =>
                {
                    b.HasOne("MovieRental.Domain.Entities.Review", "Review")
                        .WithMany("Responses")
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Review");
                });

            modelBuilder.Entity("MovieRental.Domain.Entities.Review", b =>
                {
                    b.HasOne("MovieRental.Domain.Entities.Movie", "Movie")
                        .WithMany("Reviews")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("MovieRental.Domain.Entities.Movie", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("MovieRental.Domain.Entities.Review", b =>
                {
                    b.Navigation("Responses");
                });
#pragma warning restore 612, 618
        }
    }
}
