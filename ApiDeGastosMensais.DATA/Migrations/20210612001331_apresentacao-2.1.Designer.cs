﻿// <auto-generated />
using System;
using ApiDeGastosMensais.DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiDeGastosMensais.DATA.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210612001331_apresentacao-2.1")]
    partial class apresentacao21
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("ApiDeGastosMensais.DATA.Model.Gasto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDeRegistro")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(32,2)");

                    b.Property<string>("descricao")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Gasto");
                });
#pragma warning restore 612, 618
        }
    }
}
