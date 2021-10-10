using Microsoft.EntityFrameworkCore;
using SmartGowala.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGowala.Data.Data.Context
{
    public class SmartGowalaDBContext : DbContext
    {
        public SmartGowalaDBContext(DbContextOptions<SmartGowalaDBContext> options) : base(options)
        {
            
        }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<ActionTracker> ActionTracker { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRole>(
                entity =>
                {
                    entity.Property(e => e.RoleName).IsRequired().HasMaxLength(50);
                }
            );
            modelBuilder.Entity<ActionTracker>(
                entity =>
                {
                }
            );
        }
    }
}
