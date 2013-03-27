using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SchoolCup.Models.POCO;

using System.Data.Entity.ModelConfiguration.Conventions;

namespace SchoolCup.Models.DAL
{
  public class EFDbContext : DbContext
  {

    public EFDbContext()
      : base("Kdg_Schoolcup_Version02")
    {
    }
 
    public DbSet<Advertisement> Advertisements { get; set; }
    public DbSet<CoachCoordinator> CoachCoordinators { get; set; }
    public DbSet<Continent> Continents { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Discipline> Disciplines { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<ISF> ISFs { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Meeting> Meetings { get; set; }
    public DbSet<NSF> NSFs { get; set; }
    public DbSet<Record> Records { get; set; }
    public DbSet<Region> Regions { get; set; }
    public DbSet<Representative> Representatives { get; set; }
    public DbSet<Result> Results { get; set; }
    public DbSet<School> Schools { get; set; }
    public DbSet<Sport> Sports { get; set; }
    
    public DbSet<Subscription> Subscriptions { get; set; }
    public DbSet<Team> Teams { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
      modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
      modelBuilder.Entity<NSF>().HasMany(r => r.Regions).WithMany();
      modelBuilder.Entity<Advertisement>().HasMany(c => c.Continents).WithMany();
      modelBuilder.Entity<Advertisement>().HasMany(c => c.Countries).WithMany();

    }
  }
}