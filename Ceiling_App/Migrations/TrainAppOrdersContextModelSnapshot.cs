﻿// <auto-generated />
using System;
using Ceiling_App.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ceiling_App.Migrations
{
    [DbContext(typeof(TrainAppOrdersContext))]
    partial class TrainAppOrdersContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Ceiling_App.Model.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTimeOffset>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetimeoffset")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Ceiling_App.Model.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetimeoffset")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("Lustra")
                        .HasColumnType("int");

                    b.Property<string>("OrderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("P")
                        .HasColumnType("float");

                    b.Property<int>("Pipe")
                        .HasColumnType("int");

                    b.Property<double>("S")
                        .HasColumnType("float");

                    b.Property<int>("Spotlight")
                        .HasColumnType("int");

                    b.Property<int>("Ugl")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex(new[] { "ClientId" }, "IX_FK_ClientOrder");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Ceiling_App.Model.Order", b =>
                {
                    b.HasOne("Ceiling_App.Model.Client", "Client")
                        .WithMany("Orders")
                        .HasForeignKey("ClientId")
                        .HasConstraintName("FK_ClientOrder")
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Ceiling_App.Model.Client", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
