using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;
using TextingSaver.Domain;


namespace TextingSaver.infracture
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options):base(options)
        {
        }

        public DbSet<RTE> RTEs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<RTE>(
                eb =>
                {
                    eb.HasNoKey();
                });
        }
    }
}
