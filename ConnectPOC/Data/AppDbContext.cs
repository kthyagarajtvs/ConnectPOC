using ConnectPOC.Models;
using Microsoft.EntityFrameworkCore;

namespace ConnectPOC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<UserVehicle> UserVehicles { get; set; }
        public DbSet<N109Cumulative> N109Cumulatives { get; set; }
        public DbSet<ApacheCumulative> ApacheCumulatives { get; set; }

        public DbSet<ApacheNONIOTCumulative> ApacheNONIOTCumulative { get; set; }

        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // UserProfile -> UserVehicles (One-to-Many)
            modelBuilder.Entity<UserProfile>()
                .HasMany(u => u.UserVehicles)
                .WithOne(v => v.UserProfile)
                .HasForeignKey(v => v.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // UserProfile -> N109Cumulatives (One-to-Many)
            modelBuilder.Entity<UserProfile>()
                .HasMany(u => u.N109Cumulatives)
                .WithOne(n => n.UserProfile)
                .HasForeignKey(n => n.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // UserProfile -> ApacheCumulatives (One-to-Many)
            modelBuilder.Entity<UserProfile>()
                .HasMany(u => u.ApacheCumulatives)
                .WithOne(a => a.UserProfile)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // UserVehicle -> N109Cumulatives (One-to-Many)
            modelBuilder.Entity<UserVehicle>()
                .HasMany(v => v.N109Cumulatives)
                .WithOne(n => n.UserVehicle)
                .HasForeignKey(n => n.UserVehicleId)
                .OnDelete(DeleteBehavior.Restrict);

            // UserVehicle -> ApacheCumulatives (One-to-Many)
            modelBuilder.Entity<UserVehicle>()
                .HasMany(v => v.ApacheCumulatives)
                .WithOne(a => a.UserVehicle)
                .HasForeignKey(a => a.UserVehicleId)
                .OnDelete(DeleteBehavior.Restrict);

            // UserProfile -> RideCumulatives (One-to-Many)
            modelBuilder.Entity<UserProfile>()
                .HasMany(u => u.RideCumulative)
                .WithOne(r => r.UserProfile)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // UserVehicle -> RideCumulatives (One-to-Many)
            modelBuilder.Entity<UserVehicle>()
                .HasMany(v => v.RideCumulative)
                .WithOne(r => r.UserVehicle)
                .HasForeignKey(r => r.UserVehicleId)
                .OnDelete(DeleteBehavior.Restrict);

            // UserProfile -> ApacheNONIOTCumulative (One-to-Many)
            modelBuilder.Entity<UserProfile>()
                .HasMany(u => u.ApacheNONIOTCumulative)
                .WithOne(a => a.UserProfile)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // UserVehicle -> ApacheNONIOTCumulative (One-to-Many)
            modelBuilder.Entity<UserVehicle>()
                .HasMany(v => v.ApacheNONIOTCumulative)
                .WithOne(r => r.UserVehicle)
                .HasForeignKey(r => r.UserVehicleId)
                .OnDelete(DeleteBehavior.Restrict);

            // UserProfile -> N251BLECumulative (One-to-Many)
            modelBuilder.Entity<UserProfile>()
                .HasMany(u => u.N251BLECumulative)
                .WithOne(a => a.UserProfile)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // UserVehicle -> N251BLECumulative (One-to-Many)
            modelBuilder.Entity<UserVehicle>()
                .HasMany(v => v.N251BLECumulative)
                .WithOne(r => r.UserVehicle)
                .HasForeignKey(r => r.UserVehicleId)
                .OnDelete(DeleteBehavior.Restrict);

            // UserProfile -> U347Cumulative (One-to-Many)
            modelBuilder.Entity<UserProfile>()
                .HasMany(u => u.U347Cumulative)
                .WithOne(a => a.UserProfile)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // UserVehicle -> U347Cumulative (One-to-Many)
            modelBuilder.Entity<UserVehicle>()
                .HasMany(v => v.U347Cumulative)
                .WithOne(r => r.UserVehicle)
                .HasForeignKey(r => r.UserVehicleId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<City>().ToTable("Cities");

            modelBuilder.Entity<UserProfile>()
    .HasOne(up => up.City)
    .WithMany()
    .HasForeignKey(up => up.CityId)
    .OnDelete(DeleteBehavior.Restrict);


            // Ensure Primary Keys for all tables
            modelBuilder.Entity<UserProfile>().HasKey(u => u.UserId);
            modelBuilder.Entity<UserVehicle>().HasKey(v => v.UserVehicleId);
            modelBuilder.Entity<N109Cumulative>().HasKey(n => n.N109CumulativeId);
            modelBuilder.Entity<ApacheCumulative>().HasKey(a => a.ApacheCumulativeId);
            modelBuilder.Entity<RideCumulative>().HasKey(r => r.RideCumulativeId);
            modelBuilder.Entity<ApacheNONIOTCumulative>().HasKey(r => r.ApacheCumulativeId);
            modelBuilder.Entity<N251BLECumulative>().HasKey(r => r.N251BLECumulativeId);
            modelBuilder.Entity<U347Cumulative>().HasKey(r => r.U347CumulativeId);
            modelBuilder.Entity<VehicleType>().HasKey(r => r.VehicleTypeId);
            modelBuilder.Entity<EmergencyContact>().HasKey(r => r.EmergencyContactId);
            modelBuilder.Entity<HomeVideo>().HasKey(r => r.VideoLinkId);
            modelBuilder.Entity<City>().HasKey(r => r.CityId);

            modelBuilder.Entity<City>().HasData(
       new City { CityId = 1, CityName = "Bangalore" },
       new City { CityId = 2, CityName = "Chennai" },
       new City { CityId = 3, CityName = "Pune" },
       new City { CityId = 4, CityName = "Dehradun" }
   );


        }



    }
}
