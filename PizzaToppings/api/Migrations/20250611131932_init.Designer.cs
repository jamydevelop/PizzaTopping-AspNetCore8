﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api.Data;

#nullable disable

namespace api.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20250611131932_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("api.Models.Pizza", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.ToTable("Pizzas");
                });

            modelBuilder.Entity("api.Models.PizzaTopping", b =>
                {
                    b.Property<int>("PizzaId")
                        .HasColumnType("int");

                    b.Property<int>("ToppingId")
                        .HasColumnType("int");

                    b.HasKey("PizzaId", "ToppingId");

                    b.HasIndex("ToppingId");

                    b.ToTable("PizzasToppings");
                });

            modelBuilder.Entity("api.Models.Topping", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("Pizzaid")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.HasIndex("Pizzaid");

                    b.ToTable("Toppings");
                });

            modelBuilder.Entity("api.Models.PizzaTopping", b =>
                {
                    b.HasOne("api.Models.Pizza", "Pizza")
                        .WithMany("PizzaToppings")
                        .HasForeignKey("PizzaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api.Models.Topping", "Topping")
                        .WithMany("PizzaToppings")
                        .HasForeignKey("ToppingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pizza");

                    b.Navigation("Topping");
                });

            modelBuilder.Entity("api.Models.Topping", b =>
                {
                    b.HasOne("api.Models.Pizza", null)
                        .WithMany("Toppings")
                        .HasForeignKey("Pizzaid");
                });

            modelBuilder.Entity("api.Models.Pizza", b =>
                {
                    b.Navigation("PizzaToppings");

                    b.Navigation("Toppings");
                });

            modelBuilder.Entity("api.Models.Topping", b =>
                {
                    b.Navigation("PizzaToppings");
                });
#pragma warning restore 612, 618
        }
    }
}
