using System;
using Microsoft.EntityFrameworkCore;
using nutrition_planner.Models;



namespace nutrition_planner.Data
{
    public class FoodModelContext : DbContext
    {
        private readonly IConfiguration _config;

        public FoodModelContext(DbContextOptions<FoodModelContext> options) : base(options){}

        public DbSet<FoodModel> FoodModels { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("food_schema");
        }            
    }
}
