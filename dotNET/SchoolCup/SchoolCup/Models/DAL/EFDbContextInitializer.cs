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
      //Creation ISF
      ISF isf = new ISF{PhoneNumber = "+3232860738"};
      context.ISFs.Add(isf);

      //Creation Sports
      Sport athletiek = new Sport{Type = "Athletiek"};
      Sport swimming = new Sport{Type = "Swimming"};
      context.Sports.Add(athletiek);
      context.Sports.Add(swimming);

      //Creation Disciplines
      Discipline discipline1 = new Discipline{IsTime = true, Sport = athletiek, MinTimeDistance = 10, MaxTimeDistance = 60,Name = "Discipline1"};
      Discipline discipline2 = new Discipline { IsTime = true, Sport = athletiek, MinTimeDistance = 10, MaxTimeDistance = 60, Name = "Discipline2" };
      Discipline discipline3 = new Discipline { IsTime = true, Sport = swimming, MinTimeDistance = 10, MaxTimeDistance = 60, Name = "Discipline3" };
      Discipline discipline4 = new Discipline { IsTime = true, Sport = swimming, MinTimeDistance = 10, MaxTimeDistance = 60, Name = "Discipline4" };
      context.Disciplines.Add(discipline1);
      context.Disciplines.Add(discipline2);
      context.Disciplines.Add(discipline3);
      context.Disciplines.Add(discipline4);

      //Add disciplines to sport
      athletiek.Disciplines.Add(discipline1);
      athletiek.Disciplines.Add(discipline2);
      swimming.Disciplines.Add(discipline3);
      swimming.Disciplines.Add(discipline4);

      //Creation Records
      Record record = new Record {Name = "Record1",DateObtained = new DateTime(2012,10,25), DateOfBirth = new DateTime(1982,12,25), Gender = 'M', Kind = "Schoolcup", TimeDistance = 20, Discipline = discipline1};
      context.Records.Add(record);

      //Creation Continents
      Continent continent = new Continent{Name = "Europe"};
      context.Continents.Add(continent);

      //Creation Countries
      Country country = new Country {Continent = continent, Name = "Belgium"};
      context.Countries.Add(country);
      Country country2 = new Country { Continent = continent, Name = "France" };
      context.Countries.Add(country2);

      //Creation Regions
      Region region1 = new Region{Country = country, Name = "Oost-Vlaanderen"};

      //Creation Locations
      Location location = new Location {Country = country,City = "Antwerp"};
      context.Locations.Add(location);

      //Creation Representative NSF
      Representative representative1 = new Representative{Name = "Thomas", Function = "Vertegenwoordiger", Email = "thomas@schoolcup.org"};
      context.Representatives.Add(representative1);

      //Creation NSFs
      NSF nsf1 = new NSF{FaxNumber = "037707045",Name = "NSF1",Location = location, PhoneNumber = "037707045", YearOfMembership = 2012, Representative = representative1};
      context.NSFs.Add(nsf1);

      //Student student1 = new Student{Gender = 'm',Name = "Thomas"};
      //context.Students.Add(student1);
      context.SaveChanges();
     }
  }
}