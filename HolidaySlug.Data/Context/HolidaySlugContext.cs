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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Holiday>().HasKey(h => h.ID);
            modelBuilder.Entity<Holiday>().HasOne(h => h.User).WithMany(u => u.Holidays);
            modelBuilder.Entity<Holiday>().HasOne(h => h.ApprovedByUser);

            modelBuilder.Entity<User>().HasKey(u => u.ID);
            modelBuilder.Entity<User>().HasOne(u => u.UserTeam).WithMany(u=>u.Users);
      


            modelBuilder.Entity<UserTeam>().HasKey(ut => ut.ID);
            modelBuilder.Entity<UserTeam>().HasOne(ut => ut.Manager);

            




        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Server=localhost; Database=HolidaySlugDB; User=sa; Password=boopboop2306@@;");
        }
    }
}