using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SchoolCup.Models.POCO;
using System.Data.Entity;


namespace SchoolCup.Models.DAL
{
  public class EFDbContextInitializer : DropCreateDatabaseAlways<EFDbContext>
  {
    protected override void Seed(EFDbContext context)
    {
      ISF isf = new ISF{PhoneNumber = "+3232860738"};
      context.ISFs.Add(isf);
      Continent continent = new Continent{Name = "Europe"};
      context.Continents.Add(continent);
      Country country = new Country {Continent = continent, Name = "Belgium"};
      context.Countries.Add(country);
      Country country2 = new Country { Continent = continent, Name = "France" };
      context.Countries.Add(country2);
      Location location = new Location {Country = country,City = "Antwerp"};
      context.Locations.Add(location);
      //Student student1 = new Student{Gender = 'm',Name = "Thomas"};
      //context.Students.Add(student1);
      context.SaveChanges();
     }
  }
}