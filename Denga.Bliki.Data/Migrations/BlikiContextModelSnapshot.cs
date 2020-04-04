﻿// <auto-generated />
using System;
using Denga.Bliki.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Denga.Bliki.Data.Migrations
{
    [DbContext(typeof(BlikiContext))]
    partial class BlikiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Denga.Bliki.Data.BlikiPageContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlikiPageMetaDataId")
                        .HasColumnType("int");

                    b.Property<string>("HtmlContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BlikiPageMetaDataId");

                    b.ToTable("BlikiPageContents");
                });

            modelBuilder.Entity("Denga.Bliki.Data.BlikiPageMetaData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LatestVersionId")
                        .HasColumnType("int");

                    b.Property<string>("UrlTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LatestVersionId");

                    b.ToTable("BlikiPageMetaDatas");
                });

            modelBuilder.Entity("Denga.Bliki.Data.BlikiPageContent", b =>
                {
                    b.HasOne("Denga.Bliki.Data.BlikiPageMetaData", "MetaData")
                        .WithMany()
                        .HasForeignKey("BlikiPageMetaDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Denga.Bliki.Data.BlikiPageMetaData", b =>
                {
                    b.HasOne("Denga.Bliki.Data.BlikiPageContent", "LatestVersion")
                        .WithMany()
                        .HasForeignKey("LatestVersionId");
                });
#pragma warning restore 612, 618
        }
    }
}
