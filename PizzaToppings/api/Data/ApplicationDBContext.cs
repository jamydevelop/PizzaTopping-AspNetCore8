using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace api.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Topping> Toppings { get; set; }
        public DbSet<PizzaTopping> PizzasToppings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    // COMPOSITE PRIMARY KEY
    modelBuilder.Entity<PizzaTopping>()
        .HasKey(pt => new { pt.PizzaId, pt.ToppingId });

    // CONNECTING TO PIZZA
    modelBuilder.Entity<PizzaTopping>()
        .HasOne(pt => pt.Pizza)
        .WithMany(p => p.PizzaToppings)
        .HasForeignKey(pt => pt.PizzaId);

    // CONNECTING TO TOPPING
    modelBuilder.Entity<PizzaTopping>()
        .HasOne(pt => pt.Topping)
        .WithMany(t => t.PizzaToppings)
        .HasForeignKey(pt => pt.ToppingId);
}

    }
}