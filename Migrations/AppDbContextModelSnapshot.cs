﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using aoe2_server.DBContext;

namespace aoe2_server.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("aoe2_server.Models.Group", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<long[]>("PlayerIDs");

                    b.HasKey("ID");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("aoe2_server.Models.Player", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<short>("Age");

                    b.Property<long?>("GroupID");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("GroupID");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("aoe2_server.Models.Player", b =>
                {
                    b.HasOne("aoe2_server.Models.Group")
                        .WithMany("Players")
                        .HasForeignKey("GroupID");
                });
#pragma warning restore 612, 618
        }
    }
}
