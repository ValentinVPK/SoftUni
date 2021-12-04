﻿namespace Theatre.Data
{
    using Microsoft.EntityFrameworkCore;
    using Theatre.Data.Models;

    public class TheatreContext : DbContext
    {
        public TheatreContext() { }

        public TheatreContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Theatre> Theatres { get; set; }

        public DbSet<Play> Plays { get; set; }

        public DbSet<Cast> Casts { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(Configuration.ConnectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Ticket>()
                .HasOne(x => x.Theatre)
                .WithMany(x => x.Tickets)
                .HasForeignKey(x => x.TheatreId);

            builder.Entity<Theatre>()
                .HasMany(x => x.Tickets)
                .WithOne(x => x.Theatre)
                .HasForeignKey(x => x.TheatreId);       
        }
    }
}
