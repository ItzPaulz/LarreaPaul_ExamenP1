﻿// <auto-generated />
using System;
using LarreaPaul_ExamenP1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LarreaPaul_ExamenP1.Migrations
{
    [DbContext(typeof(LarreaPaul_ExamenP1Context))]
    [Migration("20241029130528_Migracion2")]
    partial class Migracion2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LarreaPaul_ExamenP1.Models.Celular", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("año")
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    b.Property<int?>("clienteidNombre")
                        .HasColumnType("int");

                    b.Property<float>("precio")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("clienteidNombre");

                    b.ToTable("Celular");
                });

            modelBuilder.Entity("LarreaPaul_ExamenP1.Models.PLarrea", b =>
                {
                    b.Property<int>("idNombre")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idNombre"));

                    b.Property<DateTime>("FechaCumple")
                        .HasColumnType("datetime2");

                    b.Property<bool>("casado")
                        .HasColumnType("bit");

                    b.Property<int>("celular")
                        .HasColumnType("int");

                    b.Property<string>("correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("iq")
                        .HasMaxLength(3)
                        .HasColumnType("real");

                    b.HasKey("idNombre");

                    b.ToTable("PLarrea");
                });

            modelBuilder.Entity("LarreaPaul_ExamenP1.Models.Celular", b =>
                {
                    b.HasOne("LarreaPaul_ExamenP1.Models.PLarrea", "cliente")
                        .WithMany()
                        .HasForeignKey("clienteidNombre");

                    b.Navigation("cliente");
                });
#pragma warning restore 612, 618
        }
    }
}
