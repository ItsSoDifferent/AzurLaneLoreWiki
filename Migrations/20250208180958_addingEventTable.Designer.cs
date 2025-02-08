﻿// <auto-generated />
using AzurLaneLoreWiki.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AzurLaneLoreWiki.Migrations
{
    [DbContext(typeof(DB_WikiContentsContext))]
    [Migration("20250208180958_addingEventTable")]
    partial class addingEventTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.1");

            modelBuilder.Entity("AzurLaneLoreWiki.Data.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Class")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Faction")
                        .HasColumnType("TEXT");

                    b.Property<string>("Icon")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Prefix")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("AzurLaneLoreWiki.Data.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("InDepthOverview")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("SplashArt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Events");
                });
#pragma warning restore 612, 618
        }
    }
}
