using System;
using Microsoft.EntityFrameworkCore;
using EventAPI.Models;
namespace EventAPI.Data
{
    public class EventDataContext : DbContext
    {
       public EventDataContext(DbContextOptions<EventDataContext> options)
            :base(options)
        {

        }
       /* protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>()
            .HasMany(p => p.Participants)
            .WithOne();
           // .HasForeignKey(p => p.EventId);
        }*/
        public DbSet<Event> Event { get; set; }
    }
}
