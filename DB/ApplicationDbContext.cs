using EventBookingManagementSystem_Backend.DB.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace EventBookingManagementSystem_Backend.DB
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Item_Category> Item_Categories { get; set; }
               public DbSet<Item> Items { get; set; }

       
    }
}
