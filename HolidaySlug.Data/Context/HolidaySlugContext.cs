using HolidaySlug.Data.Entities;
using Microsoft.EntityFrameworkCore;
namespace HolidaySlug.Data.Context
{
    public class HolidaySlugContext : DbContext
    {
        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<HolidayType> HolidayTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Teams> Teams { get; set; }
        public DbSet<UserTeam> UserTeams { get; set; }
        public DbSet<HolidayHistory> HolidayHistories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Holiday>().HasKey(h => h.ID);
            modelBuilder.Entity<Holiday>().HasOne(h => h.User).WithMany(u => u.Holidays);
            modelBuilder.Entity<Holiday>().HasOne(h => h.ApprovedByUser);

            modelBuilder.Entity<User>().HasKey(u => u.ID);
            modelBuilder.Entity<User>().HasOne(u => u.UserTeam);
            
            modelBuilder.Entity<UserTeam>().HasKey(ut => ut.Id);
            modelBuilder.Entity<UserTeam>().HasOne(ut => ut.Manager);
            modelBuilder.Entity<UserTeam>().HasOne(ut => ut.User);

            modelBuilder.Entity<HolidayHistory>().HasKey(h => h.Id);
            modelBuilder.Entity<HolidayHistory>().HasOne<User>();
            modelBuilder.Entity<HolidayHistory>().HasOne<Holiday>();
            


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433; Database=HolidaySlugDev;User=SA; Password=Change*This^Password34");
        }
    }
}