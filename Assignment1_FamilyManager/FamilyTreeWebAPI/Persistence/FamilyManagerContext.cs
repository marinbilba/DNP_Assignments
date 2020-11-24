using System.Linq;
using LoginExample.Models.Family.Child;
using LoginExample.Models.Family.Child.Pet;
using Microsoft.EntityFrameworkCore;
using Models;

namespace FamilyTreeWebAPI.Persistence
{
    public class FamilyManagerContext : DbContext
    {
        public DbSet<Family> Families { get; set; }
        public DbSet<Adult> Adults { get; set; }
        
        public DbSet<Child> Child { get; set; }
        public DbSet<Interest> Interest { get; set; }
        
        public DbSet<Pet> Pet { get; set; }

        public DbSet<SharedClasses.Models.User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                @"Data Source = D:\Univeristy\Projects\SEM2_DNP\RiderProjects\DNP_Assignments\Assignment1_FamilyManager\FamilyTreeWebAPI\FamilyMembersDatabase.db");
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChildInterest>()
                .HasKey(ci => new {ci.ChildId, ci.InterestId});

            modelBuilder.Entity<Family>()
                .HasKey(fam => new {fam.StreetName, fam.HouseNumber});

            modelBuilder.Entity<ChildInterest>()
                .HasOne(ci => ci.Child)
                .WithMany(child => child.ChildInterests)
                .HasForeignKey(ci => ci.ChildId);

            modelBuilder.Entity<ChildInterest>()
                .HasOne(ci => ci.Interest)
                .WithMany(i => i.ChildInterests)
                .HasForeignKey(ci => ci.InterestId);

            modelBuilder.Entity<SharedClasses.Models.User>().HasKey(x => x.UserName);
        }
    }
}