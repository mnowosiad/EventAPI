using System;
using Microsoft.EntityFrameworkCore;
using EventAPI.Models;
namespace EventAPI.Data
{
    public class ParticipantDataContext : DbContext
    {
        public ParticipantDataContext(DbContextOptions<ParticipantDataContext> options)
             :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.Entity<Participant>()
            .HasOne<Event>()
            .WithMany()
            .HasForeignKey(p => p.EventId);
            
        }
        public DbSet<Participant> Participant { get; set; }
    }
}
