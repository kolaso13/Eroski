﻿// <auto-generated />
using Eroski.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Eroski.Migrations
{
    [DbContext(typeof(TodoContext))]
    [Migration("20211220102331_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Eroski.Models.TodoItem", b =>
                {
                    b.Property<string>("Seccion")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("NumeroDeTicket")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Seccion");

                    b.ToTable("TodoItems");
                });
#pragma warning restore 612, 618
        }
    }
}