using Microsoft.EntityFrameworkCore;
using UberSystem.Models;

namespace UberSystem.Data
{
    public class UberContext : DbContext
    {
        public UberContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Ride> Rides { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasOne(u => u.Vehicle).WithOne(u => u.Driver).HasForeignKey<Vehicle>(u => u.DriverId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Ride>().HasOne(u => u.Payment).WithOne(u => u.Ride).HasForeignKey<Payment>(u => u.RideId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Ride>().HasOne(u => u.Rating).WithOne(u => u.Ride).HasForeignKey<Rating>(u => u.RideId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>().HasMany(u => u.Drives).WithOne(u => u.Driver).HasForeignKey(u => u.DriverId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<User>().HasMany(u => u.Rides).WithOne(u => u.Rider).HasForeignKey(u => u.RiderId).OnDelete(DeleteBehavior.NoAction);  
        }
    }
}
