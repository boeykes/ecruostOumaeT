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
      /*
       * OPMERKING !
       * - Er zijn nog geen trainingsmeetings in verwerkt.
       * - France heeft geen locaties en ook geen regions. Dit is met opzet gedaan om een mogelijke null pointer te krijgen.
       * - advertisement 1 => zichtbaar voor continent 1
       *                   => zichtbaar voor athletiek
       * - advertisement 2 => zichtbaar voor country 1
       *                   => zichtbaar voor swimming
       */

      /*
       * ==========================================
       * Creation Objects (relations at the bottom)
       * ==========================================
       */

      #region ISF
      
      ISF isf = new ISF{PhoneNumber = "+3232860738", Records = new List<Record>(), Advertisements = new List<Advertisement>(), NFSs = new List<NSF>()};
    
      #endregion
      #region Sport

      Sport athletiek = new Sport{Type = "Athletiek", Disciplines = new List<Discipline>(),Teams = new List<Team>()};
      Sport swimming = new Sport { Type = "Swimming", Disciplines = new List<Discipline>(), Teams = new List<Team>() };
    

      #endregion
      #region Discipline

      Discipline discipline1 = new Discipline{IsTime = true, MinTimeDistance = 10, MaxTimeDistance = 60,Name = "Discipline1"};
      Discipline discipline2 = new Discipline { IsTime = true, MinTimeDistance = 10, MaxTimeDistance = 60, Name = "Discipline2" };
      Discipline discipline3 = new Discipline { IsTime = true, MinTimeDistance = 10, MaxTimeDistance = 60, Name = "Discipline3" };
      Discipline discipline4 = new Discipline { IsTime = true, MinTimeDistance = 10, MaxTimeDistance = 60, Name = "Discipline4" };
      Discipline discipline5 = new Discipline { IsTime = true, MinTimeDistance = 10, MaxTimeDistance = 60, Name = "Discipline5" };
      Discipline discipline6 = new Discipline { IsTime = true, MinTimeDistance = 10, MaxTimeDistance = 60, Name = "Discipline6" };
     

      #endregion
      #region Record

      Record record = new Record {Name = "Record1",DateObtained = new DateTime(2012,10,25), DateOfBirth = new DateTime(1982,12,25), Gender = 'M', Kind = "Schoolcup", TimeDistance = 20};
   

      #endregion
      #region Continent

      Continent continent = new Continent{Name = "Europe", Countries = new List<Country>()};
   

      #endregion
      #region Country

      Country country1 = new Country {Name = "Belgium", Regions = new List<Region>()};
      Country country2 = new Country { Name = "France", Regions = new List<Region>() };
    

      #endregion
      #region Region

      Region region1 = new Region{Name = "Oost-Vlaanderen", Meetings = new List<Meeting>(), Schools = new List<School>()};
      Region region2 = new Region { Name = "West-Vlaanderen", Meetings = new List<Meeting>(), Schools = new List<School>() };
      Region region3 = new Region { Name = "Antwerpen", Meetings = new List<Meeting>(), Schools = new List<School>() };
      Region region4 = new Region { Name = "Vlaams-Brabant", Meetings = new List<Meeting>(), Schools = new List<School>() };
      Region region5 = new Region { Name = "Limburg", Meetings = new List<Meeting>(), Schools = new List<School>() };
    
      #endregion
      #region Location

      Location location1 = new Location {Street = "location1Street", HomeNumber = "1", ZipCode = "1", City = "Location1"};
      Location location2 = new Location { Street = "location2Street", HomeNumber = "2", ZipCode = "2", City = "Location2" };
      Location location3 = new Location { Street = "location3Street", HomeNumber = "3", ZipCode = "3", City = "Location3" };
      Location location4 = new Location { Street = "location4Street", HomeNumber = "4", ZipCode = "4", City = "Location4" };
      Location location5 = new Location { Street = "location5Street", HomeNumber = "5", ZipCode = "5", City = "Location5" };
      Location location6 = new Location { Street = "location6Street", HomeNumber = "6", ZipCode = "6", City = "Location6" };
      Location location7 = new Location { Street = "location7Street", HomeNumber = "7", ZipCode = "7", City = "Location7" };
      Location location8 = new Location { Street = "location8Street", HomeNumber = "8", ZipCode = "8", City = "Location8" };
      Location location9 = new Location { Street = "location9Street", HomeNumber = "9", ZipCode = "9", City = "Location9" };
      Location location10 = new Location { Street = "location10Street", HomeNumber = "10", ZipCode = "10", City = "Location10" };
      Location location11 = new Location { Street = "location11Street", HomeNumber = "11", ZipCode = "11", City = "Location11" };
      Location location12 = new Location { Street = "location12Street", HomeNumber = "12", ZipCode = "12", City = "Location12" };
      Location location13 = new Location { Street = "location13Street", HomeNumber = "13", ZipCode = "13", City = "Location13" };
      Location location14 = new Location { Street = "location14Street", HomeNumber = "14", ZipCode = "14", City = "Location14" };
      Location location15 = new Location { Street = "location15Street", HomeNumber = "15", ZipCode = "15", City = "Location15" };
      Location location16 = new Location { Street = "location16Street", HomeNumber = "16", ZipCode = "16", City = "Location16" };
      Location location17 = new Location { Street = "location17Street", HomeNumber = "17", ZipCode = "17", City = "Location17" };
      Location location18 = new Location { Street = "location18Street", HomeNumber = "18", ZipCode = "18", City = "Location18" };
      Location location19 = new Location { Street = "location19Street", HomeNumber = "19", ZipCode = "19", City = "Location19" };
      Location location20 = new Location { Street = "location20Street", HomeNumber = "20", ZipCode = "20", City = "Location20" };
      Location location21 = new Location { Street = "location21Street", HomeNumber = "21", ZipCode = "21", City = "Location21" };
      Location location22 = new Location { Street = "location22Street", HomeNumber = "22", ZipCode = "22", City = "Location22" };
      Location location23 = new Location { Street = "location23Street", HomeNumber = "23", ZipCode = "23", City = "Location23" };
      Location location24 = new Location { Street = "location24Street", HomeNumber = "24", ZipCode = "24", City = "Location24" };
      Location location25 = new Location { Street = "location25Street", HomeNumber = "25", ZipCode = "25", City = "Location25" };
      Location location26 = new Location { Street = "location26Street", HomeNumber = "26", ZipCode = "26", City = "Location26" };
      Location location27 = new Location { Street = "location27Street", HomeNumber = "27", ZipCode = "27", City = "Location27" };
      Location location28 = new Location { Street = "location28Street", HomeNumber = "28", ZipCode = "28", City = "Location28" };
      Location location29 = new Location { Street = "location29Street", HomeNumber = "29", ZipCode = "29", City = "Location29" };
    
      #endregion
      #region Advertisement

      Advertisement advertisement1 = new Advertisement{Name = "ad1", StartDate = new DateTime(2013,01,10), EndDate = new DateTime(2013,05,10), 
        Continents = new List<Continent>(), Countries = new List<Country>(), Sports = new List<Sport>()};
      Advertisement advertisement2 = new Advertisement { Name = "ad1", StartDate = new DateTime(2013, 02, 01), EndDate = new DateTime(2013, 07, 06), 
        Continents = new List<Continent>(), Countries = new List<Country>(), Sports = new List<Sport>()};

      #endregion
      #region Representative

      Representative representative1 = new Representative { Name = "representative1", Function = "Vertegenwoordiger", Email = "representative1@schoolcup.org" };
      Representative representative2 = new Representative { Name = "representative2", Function = "Vertegenwoordiger", Email = "representative2@schoolcup.org" };
    

      #endregion
      #region NSF

      NSF nsf1 = new NSF{FaxNumber = "037707045",Name = "NSF1", PhoneNumber = "037707045", YearOfMembership = 2012, Regions = new List<Region>(), Schools = new List<School>()};
      NSF nsf2 = new NSF { FaxNumber = "031547865", Name = "NSF2", PhoneNumber = "031512865", YearOfMembership = 2011, Regions = new List<Region>(), Schools = new List<School>() };
     

      #endregion
      #region School

      School school1 = new School {Name = "KdG Groenplaats",WebsiteURL = "http://www.kdg.be", EMail = "info@kdg.be",Phone = "037701285", 
        Students = new List<Student>(), Teams = new List<Team>(), CoachCoordinators = new List<CoachCoordinator>()};
      School school2 = new School { Name = "KU Leuven", WebsiteURL = "http://www.kuleuven.be/kuleuven/", EMail = "info@kuleuven.be", Phone = "075149621", 
        Students = new List<Student>(), Teams = new List<Team>(), CoachCoordinators = new List<CoachCoordinator>()};
      

      #endregion
      #region Coordinator

      CoachCoordinator coordinator1 = new CoachCoordinator { Name = "coordinator1",isCoordinator = true, Phone = "0345872318", EMail = "coordinator1@school1.be", Mobile = "0425123548", 
        Schools = new List<School>(), Teams = new List<Team>()};
      CoachCoordinator coordinator2 = new CoachCoordinator { Name = "coordinator2",isCoordinator = true, Phone = "0345876254", EMail = "coordinator2@school2.be", Mobile = "0412578965",
        Schools = new List<School>(), Teams = new List<Team>()};
      

      #endregion
      #region Coach

      CoachCoordinator coach1 = new CoachCoordinator { Name = "coach1",isCoordinator = false, Phone = "034578621", EMail = "coach1@school1.be", Mobile = "0423548521", 
        Schools = new List<School>(), Teams = new List<Team>()};
      CoachCoordinator coach2 = new CoachCoordinator { Name = "coach2",isCoordinator = false, Phone = "035412365", EMail = "coach2@school1.be", Mobile = "0412547896", 
        Schools = new List<School>(), Teams = new List<Team>()};
      CoachCoordinator coach3 = new CoachCoordinator { Name = "coach3",isCoordinator = false, Phone = "032147896", EMail = "coach3@school1.be", Mobile = "0445621305", 
        Schools = new List<School>(), Teams = new List<Team>() };
      CoachCoordinator coach4 = new CoachCoordinator { Name = "coach4",isCoordinator = false, Phone = "032564789", EMail = "coach4@school2.be", Mobile = "0423451489", 
        Schools = new List<School>(), Teams = new List<Team>() };
    
      #endregion
      #region Team

      Team team1 = new Team {Name = "Team1", Results = new List<Result>(), Students = new List<Student>(), Subscriptions = new List<Subscription>()};
      Team team2 = new Team { Name = "Team2", Results = new List<Result>(), Students = new List<Student>(), Subscriptions = new List<Subscription>() };
      Team team3 = new Team { Name = "Team3", Results = new List<Result>(), Students = new List<Student>(), Subscriptions = new List<Subscription>() };
      Team team4 = new Team { Name = "Team4", Results = new List<Result>(), Students = new List<Student>(), Subscriptions = new List<Subscription>() };
    
      #endregion
      #region Student

      Student student11 = new Student { Name = "student11", DateOfBirth = new DateTime(1993, 04, 25), Gender = 'M', EMail = "student11@student.school1.be", 
       Teams = new List<Team>(), Meetings = new List<Meeting>(), Results = new List<Result>()};
      Student student12 = new Student { Name = "student12", DateOfBirth = new DateTime(1993, 04, 25), Gender = 'M', EMail = "student12@student.school1.be", 
        Teams = new List<Team>() };
      Student student13 = new Student { Name = "student13", DateOfBirth = new DateTime(1993, 05, 05), Gender = 'M', EMail = "student13@student.school1.be", 
         Teams = new List<Team>() };
      Student student14 = new Student { Name = "student14", DateOfBirth = new DateTime(1993, 06, 25), Gender = 'M', EMail = "student14@student.school1.be", 
        Teams = new List<Team>()  };

      Student student21 = new Student { Name = "student21", DateOfBirth = new DateTime(1993, 07, 25), Gender = 'V', EMail = "student21@student.school1.be", 
         Teams = new List<Team>() };
      Student student22 = new Student { Name = "student22", DateOfBirth = new DateTime(1993, 08, 25), Gender = 'V', EMail = "student22@student.school1.be", 
         Teams = new List<Team>() };
      Student student23 = new Student { Name = "student23", DateOfBirth = new DateTime(1993, 09, 25), Gender = 'V', EMail = "student23@student.school1.be", 
         Teams = new List<Team>() };
      Student student24 = new Student { Name = "student24", DateOfBirth = new DateTime(1993, 04, 24), Gender = 'V', EMail = "student24@student.school1.be", 
        Teams = new List<Team>() };

      Student student31 = new Student { Name = "student31", DateOfBirth = new DateTime(1993, 04, 23), Gender = 'V', EMail = "student31@student.school2.be", 
        Teams = new List<Team>() };
      Student student32 = new Student { Name = "student32", DateOfBirth = new DateTime(1993, 04, 12), Gender = 'V', EMail = "student32@student.school2.be", 
        Teams = new List<Team>() };
      Student student33 = new Student { Name = "student33", DateOfBirth = new DateTime(1993, 04, 15), Gender = 'V', EMail = "student33@student.school2.be", 
         Teams = new List<Team>()};
      Student student34 = new Student { Name = "student34", DateOfBirth = new DateTime(1993, 04, 17), Gender = 'V', EMail = "student34@student.school2.be", 
        Teams = new List<Team>() };

      Student student41 = new Student { Name = "student41", DateOfBirth = new DateTime(1993, 04, 01), Gender = 'M', EMail = "student41@student.school2.be", 
         Teams = new List<Team>()  };
      Student student42 = new Student { Name = "student42", DateOfBirth = new DateTime(1993, 04, 03), Gender = 'M', EMail = "student42@student.school2.be", 
         Teams = new List<Team>()  };
      Student student43 = new Student { Name = "student43", DateOfBirth = new DateTime(1993, 04, 05), Gender = 'M', EMail = "student43@student.school2.be", 
        Teams = new List<Team>() };
      Student student44 = new Student { Name = "student44", DateOfBirth = new DateTime(1993, 04, 07), Gender = 'M', EMail = "student44@student.school2.be", 
        Teams = new List<Team>()  };

  

      #endregion
      #region Subscription

      Subscription subscription1 = new Subscription { Date = new DateTime(2013, 01, 10) };
      Subscription subscription2 = new Subscription { Date = new DateTime(2013, 01, 11) };
      Subscription subscription3 = new Subscription { Date = new DateTime(2013, 01, 12) };
      Subscription subscription4 = new Subscription { Date = new DateTime(2013, 01, 13) };
      Subscription subscription5 = new Subscription { Date = new DateTime(2013, 01, 14) };
      Subscription subscription6 = new Subscription { Date = new DateTime(2013, 01, 15) };
    

      #endregion
      #region Meeting

      Meeting meeting1 = new Meeting{Name = "meeting1", Date = new DateTime(2013,02,20), Events = new List<Event>(), Subscriptions = new List<Subscription>()};
      Meeting meeting2 = new Meeting { Name = "meeting2", Date = new DateTime(2013, 02, 21), Events = new List<Event>(), Subscriptions = new List<Subscription>() };
      Meeting meeting3 = new Meeting { Name = "meeting3", Date = new DateTime(2013, 02, 22), Events = new List<Event>(), Subscriptions = new List<Subscription>() };
      Meeting meeting4 = new Meeting { Name = "meeting4Training", Date = new DateTime(2013, 02, 23), Events = new List<Event>(), Subscriptions = new List<Subscription>() };    //Trainingsmeeting

      #endregion
      #region Event

      Event event1 = new Event{SchoolCupEvent = false, Results = new List<Result>()};
      Event event2 = new Event { SchoolCupEvent = false, Results = new List<Result>() };
      Event event3 = new Event { SchoolCupEvent = false, Results = new List<Result>() };
      Event event4 = new Event { SchoolCupEvent = false, Results = new List<Result>() };
      Event event5 = new Event { SchoolCupEvent = false, Results = new List<Result>() };
      Event event6 = new Event { SchoolCupEvent = false, Results = new List<Result>() };
      Event event7 = new Event { SchoolCupEvent = false, Results = new List<Result>() };
      Event event8 = new Event { SchoolCupEvent = false, Results = new List<Result>() };
      Event event9 = new Event { SchoolCupEvent = false, Results = new List<Result>() };
      Event event10 = new Event { SchoolCupEvent = false, Results = new List<Result>() }; //TrainingsEvent
      Event event11 = new Event { SchoolCupEvent = false, Results = new List<Result>() }; //TrainingsEvent
     
      #endregion
      #region Result

      Result result1 = new Result{TimeDistance = 20.0, Points = 20};
      Result result2 = new Result { TimeDistance = 20.1, Points = 30 };
      Result result3 = new Result { TimeDistance = 20.2, Points = 40 };
      Result result4 = new Result { TimeDistance = 20.3, Points = 50 };
      Result result5 = new Result { TimeDistance = 20.4, Points = 60 };
      Result result6 = new Result { TimeDistance = 21.0, Points = 70 };
      Result result7 = new Result { TimeDistance = 22.0, Points = 80 };
      Result result8 = new Result { TimeDistance = 20.5, Points = 61 };
      Result result9 = new Result { TimeDistance = 19.0, Points = 19 };
      Result result10 = new Result { TimeDistance = 18.0, Points = 18 };
      Result result11 = new Result { TimeDistance = 23.0, Points = 90 };
      Result result12 = new Result { TimeDistance = 25.0, Points = 100 };
      Result result13 = new Result { TimeDistance = 17.0, Points = 71 };
      Result result14 = new Result { TimeDistance = 22.1, Points = 72 };
      Result result15 = new Result { TimeDistance = 22.2, Points = 73 };
      Result result16 = new Result { TimeDistance = 22.3, Points = 74 };
      Result result17 = new Result { TimeDistance = 22.4, Points = 75 };
      Result result18 = new Result { TimeDistance = 22.5, Points = 76 };
      Result result19 = new Result { TimeDistance = 22.5, Points = 76 }; //TrainingsResult
      Result result20 = new Result { TimeDistance = 22.5, Points = 76 }; //TrainingsResult

      #endregion

      
      /*
       * ===================
       * Creation relations
       * ===================
       */

      #region ISF

      //ISF -> record
      isf.Records.Add(record);

      //ISF -> NSF
      isf.NFSs.Add(nsf1);
      isf.NFSs.Add(nsf2);

      //ISF -> Location
      isf.Location = location1;

      //ISF -> Advertisement
      isf.Advertisements.Add(advertisement1);
      isf.Advertisements.Add(advertisement2);

      #endregion
      #region NSF

      //NSF -> Representative
      nsf1.Representative = representative1;
      nsf2.Representative = representative2;

      //NSF -> Location
      nsf1.Location = location2;
      nsf2.Location = location3;

      //NSF -> Region
      nsf1.Regions.Add(region1);
      nsf1.Regions.Add(region2);
      nsf1.Regions.Add(region3);
      nsf2.Regions.Add(region4);
      nsf2.Regions.Add(region5);

      //NSF -> School
      nsf1.Schools.Add(school1);
      nsf2.Schools.Add(school2);

      #endregion
      #region Location

      //Location -> Country
      location1.Country = country1;
      location2.Country = country1;
      location3.Country = country1;
      location4.Country = country1;
      location5.Country = country1;
      location6.Country = country1;
      location7.Country = country1;
      location8.Country = country1;
      location9.Country = country1;
      location10.Country = country1;
      location11.Country = country1;
      location12.Country = country1;
      location13.Country = country1;
      location14.Country = country1;
      location15.Country = country1;
      location16.Country = country1;
      location17.Country = country1;
      location18.Country = country1;
      location19.Country = country1;
      location20.Country = country1;
      location21.Country = country1;
      location22.Country = country1;
      location23.Country = country1;
      location24.Country = country1;
      location25.Country = country1;
      location26.Country = country1;
      location27.Country = country1;
      location28.Country = country1;
      location29.Country = country1;
      
      //Location -> Region
      location1.Region = region1;
      location2.Region = region1;
      location3.Region = region1;
      location4.Region = region1;
      location5.Region = region2;
      location6.Region = region2;
      location7.Region = region2;
      location8.Region = region2;
      location9.Region = region3;
      location10.Region = region3;
      location11.Region = region3;
      location12.Region = region3;
      location13.Region = region3;
      location14.Region = region3;
      location15.Region = region3;
      location16.Region = region3;
      location17.Region = region4;
      location18.Region = region4;
      location19.Region = region4;
      location20.Region = region4;
      location21.Region = region4;
      location22.Region = region4;
      location23.Region = region5;
      location24.Region = region5;
      location25.Region = region5;
      location26.Region = region5;
      location27.Region = region5;
      location28.Region = region5;
      location29.Region = region5;
      #endregion
      #region Continent

      //Continent -> Country
      continent.Countries.Add(country1);
      continent.Countries.Add(country2);

      #endregion
      #region Country

      //Country -> Continent
      country1.Continent = continent;
      country2.Continent = continent;

      //Country -> Region
      country1.Regions.Add(region1);
      country1.Regions.Add(region2);
      country1.Regions.Add(region3);
      country1.Regions.Add(region4);
      country1.Regions.Add(region5);

      #endregion
      #region Region

      //Region -> Country
      region1.Country = country1;
      region2.Country = country1;
      region3.Country = country1;
      region4.Country = country1;
      region5.Country = country1;

      //Region -> school
      region1.Schools.Add(school1);
      region2.Schools.Add(school2);

      //Region -> Meeting
      region1.Meetings.Add(meeting1);
      region2.Meetings.Add(meeting2);
      region3.Meetings.Add(meeting3);

      #endregion
      #region Sport

      //sport -> discipline
      athletiek.Disciplines.Add(discipline1);
      athletiek.Disciplines.Add(discipline2);
      athletiek.Disciplines.Add(discipline3);
      swimming.Disciplines.Add(discipline4);
      swimming.Disciplines.Add(discipline5);
      swimming.Disciplines.Add(discipline6);

     //Sport -> Team

      athletiek.Teams.Add(team1);
      athletiek.Teams.Add(team4);
      swimming.Teams.Add(team2);
      swimming.Teams.Add(team3);
      
      #endregion
      #region Discipline

      //discipline -> sport
      discipline1.Sport = athletiek;
      discipline2.Sport = athletiek;
      discipline3.Sport = athletiek;
      discipline4.Sport = swimming;
      discipline5.Sport = swimming;
      discipline6.Sport = swimming;

      #endregion
      #region Record

      //record -> discipline
      record.Discipline = discipline1;

      //record -> location
      record.Location = location4;

      #endregion*/
      #region School

      //School -> NSF
      school1.NSF = nsf1;
      school2.NSF = nsf2;

      //School -> region
      school1.Region = region1;
      school2.Region = region2;

      //School -> Location
      school1.Location = location4;
      school2.Location = location5;

      //School -> coordinator
      school1.CoachCoordinators.Add(coordinator1);
      school2.CoachCoordinators.Add(coordinator2);

      //School -> coach
      school1.CoachCoordinators.Add(coach1);
      school1.CoachCoordinators.Add(coach2);
      school1.CoachCoordinators.Add(coach3);
      school2.CoachCoordinators.Add(coach3);
      school2.CoachCoordinators.Add(coach4);

      //School -> Team
      school1.Teams.Add(team1);
      school1.Teams.Add(team2);
      school2.Teams.Add(team3);
      school2.Teams.Add(team4);

      //School -> student
      school1.Students.Add(student11);
      school1.Students.Add(student12);
      school1.Students.Add(student13);
      school1.Students.Add(student14);
      school1.Students.Add(student21);
      school1.Students.Add(student22);
      school1.Students.Add(student23);
      school1.Students.Add(student24);
      school2.Students.Add(student31);
      school2.Students.Add(student32);
      school2.Students.Add(student33);
      school2.Students.Add(student34);
      school2.Students.Add(student41);
      school2.Students.Add(student42);
      school2.Students.Add(student43);
      school2.Students.Add(student44);
      
      #endregion
      #region Coordinator

      //Coordinator -> Location
      coordinator1.Location = location5;
      coordinator2.Location = location6;
      
      //Coordinator -> School
      coordinator1.Schools.Add(school1);
      coordinator2.Schools.Add(school2);

      #endregion
      #region Coach

      //Coach -> Location
      coach1.Location = location7;
      coach2.Location = location8;
      coach3.Location = location9;
      coach4.Location = location10;

      //Coach -> school
      coach1.Schools.Add(school1);
      coach2.Schools.Add(school1);
      coach3.Schools.Add(school1);
      coach3.Schools.Add(school1);
      coach4.Schools.Add(school2);

      //Coach -> team
      coach1.Teams.Add(team1);
      coach2.Teams.Add(team2);
      coach3.Teams.Add(team3);
      coach4.Teams.Add(team4);
      
      #endregion
      #region Team

      //Team -> Coach
      team1.CoachCoordinator = coach1;
      team2.CoachCoordinator = coach2;
      team3.CoachCoordinator = coach3;
      team4.CoachCoordinator = coach4;

      //Team -> School 
      team1.School = school1;
      team2.School = school1;
      team3.School = school2;
      team4.School = school2;

      //Team -> Student
      team1.Students.Add(student11);
      team1.Students.Add(student12);
      team1.Students.Add(student13);
      team1.Students.Add(student14);

      team2.Students.Add(student21);
      team2.Students.Add(student22);
      team2.Students.Add(student23);
      team2.Students.Add(student24);

      team3.Students.Add(student31);
      team3.Students.Add(student32);
      team3.Students.Add(student33);
      team3.Students.Add(student34);

      team4.Students.Add(student41);
      team4.Students.Add(student42);
      team4.Students.Add(student43);
      team4.Students.Add(student44);

      //Team -> subscription
      team1.Subscriptions.Add(subscription1);
      team1.Subscriptions.Add(subscription2);
      team2.Subscriptions.Add(subscription3);
      team3.Subscriptions.Add(subscription4);
      team4.Subscriptions.Add(subscription5);
      team4.Subscriptions.Add(subscription6);
      
      //Team -> results
      team1.Results.Add(result1);
      team1.Results.Add(result2);
      team1.Results.Add(result3);

      team1.Results.Add(result4);
      team1.Results.Add(result5);
      team1.Results.Add(result6);

      team2.Results.Add(result7);
      team2.Results.Add(result8);
      team2.Results.Add(result9);

      team3.Results.Add(result10);
      team3.Results.Add(result11);
      team3.Results.Add(result12);

      team4.Results.Add(result13);
      team4.Results.Add(result14);
      team4.Results.Add(result15);

      team4.Results.Add(result16);
      team4.Results.Add(result17);
      team4.Results.Add(result18);

      //Team -> Sport
      team1.Sport = athletiek;
      team2.Sport = swimming;
      team3.Sport = swimming;
      team4.Sport = athletiek;

      #endregion
      #region Student

      //Student -> School
      student11.School = school1;
      student12.School = school1;
      student13.School = school1;
      student14.School = school1;

      student21.School = school1;
      student22.School = school1;
      student23.School = school1;
      student24.School = school1;

      student31.School = school2;
      student32.School = school2;
      student33.School = school2;
      student34.School = school2;

      student41.School = school2;
      student42.School = school2;
      student43.School = school2;
      student44.School = school2;

      //Student -> location
      student11.Location = location11;
      student12.Location = location12;
      student13.Location = location13;
      student14.Location = location14;

      student21.Location = location15;
      student22.Location = location16;
      student23.Location = location17;
      student24.Location = location18;

      student31.Location = location19;
      student32.Location = location20;
      student33.Location = location21;
      student34.Location = location22;

      student41.Location = location23;
      student42.Location = location24;
      student43.Location = location25;
      student44.Location = location26;

      //Student -> Meeting
      student11.Meetings.Add(meeting4); //trainingsmeeting

      //Student -> Result
      student11.Results.Add(result19);  //trainingsmeeting
      student11.Results.Add(result20);  //trainingsmeeting

      //Student -> Team
      student11.Teams.Add(team1);
      student12.Teams.Add(team1);
      student13.Teams.Add(team1);
      student14.Teams.Add(team1);

      student21.Teams.Add(team2);
      student22.Teams.Add(team2);
      student23.Teams.Add(team2);
      student24.Teams.Add(team2);

      student31.Teams.Add(team3);
      student32.Teams.Add(team3);
      student33.Teams.Add(team3);
      student34.Teams.Add(team3);

      student41.Teams.Add(team4);
      student42.Teams.Add(team4);
      student43.Teams.Add(team4);
      student44.Teams.Add(team4);
      
      #endregion
      #region Subscription
      
      //Subscription -> Team 
      subscription1.Team = team1;
      subscription2.Team = team1;
      subscription3.Team = team2;
      subscription4.Team = team3;
      subscription5.Team = team4;
      subscription6.Team = team4;
      
      //Subscription -> Meeting
      subscription1.Meeting = meeting1;
      subscription2.Meeting = meeting2;
      subscription3.Meeting = meeting3;
      subscription4.Meeting = meeting3;
      subscription5.Meeting = meeting1;
      subscription6.Meeting = meeting2;

      #endregion
      #region Meeting
        
      //Meeting -> Regio
      meeting1.Region = region1;
      meeting2.Region = region2;
      meeting3.Region = region3;

      //Meeting -> Location
      meeting1.Location = location27;
      meeting2.Location = location28;
      meeting3.Location = location29;

      //Meeting -> Subscription
      meeting1.Subscriptions.Add(subscription1);
      meeting1.Subscriptions.Add(subscription5);
      meeting2.Subscriptions.Add(subscription2);
      meeting2.Subscriptions.Add(subscription6);
      meeting3.Subscriptions.Add(subscription3);
      meeting3.Subscriptions.Add(subscription4);

      //Meeting -> Event
      meeting1.Events.Add(event1);
      meeting1.Events.Add(event2);
      meeting1.Events.Add(event3);

      meeting2.Events.Add(event7);
      meeting2.Events.Add(event8);
      meeting2.Events.Add(event9);

      meeting3.Events.Add(event4);
      meeting3.Events.Add(event5);
      meeting3.Events.Add(event6);

      meeting4.Events.Add(event10); //Trainingsmeeting
      meeting4.Events.Add(event11); //trainingsmeeting

      //Meeting -> Student
      meeting4.Student = student11;
      
      #endregion
      #region Event

      //Event -> Discipline
      event1.Discipline = discipline1;
      event2.Discipline = discipline2;
      event3.Discipline = discipline3;
      event4.Discipline = discipline4;
      event5.Discipline = discipline5;
      event6.Discipline = discipline6;
      event7.Discipline = discipline1;
      event8.Discipline = discipline2;
      event9.Discipline = discipline3;
      event10.Discipline = discipline1; //trainingsmeeting
      event11.Discipline = discipline2; //trainingsmeeting

      //Event -> Result
      event1.Results.Add(result1);  //team1
      event1.Results.Add(result13); //team4
      event2.Results.Add(result2);  //team1
      event2.Results.Add(result14); //team4
      event3.Results.Add(result3);  //team1
      event3.Results.Add(result15); //team4
      event4.Results.Add(result7);  //team2
      event4.Results.Add(result10); //team3
      event5.Results.Add(result8);  //team2
      event5.Results.Add(result11); //team3
      event6.Results.Add(result9);  //team2
      event6.Results.Add(result12); //team3
      event7.Results.Add(result4);  //team1
      event7.Results.Add(result16); //team4
      event8.Results.Add(result5);  //team1
      event8.Results.Add(result17); //team4
      event9.Results.Add(result6);  //team1
      event9.Results.Add(result18); //team4
      event10.Results.Add(result19);//Traingingsmeeting student11
      event11.Results.Add(result20);//Traingingsmeeting student11
      
      #endregion
      #region Result

      //Result -> Team
      result1.Team = team1;
      result2.Team = team1;
      result3.Team = team1;
      result4.Team = team1;
      result5.Team = team1;
      result6.Team = team1;
      result7.Team = team2;
      result8.Team = team2;
      result9.Team = team2;
      result10.Team = team3;
      result11.Team = team3;
      result12.Team = team3;
      result13.Team = team4;
      result14.Team = team4;
      result15.Team = team4;
      result16.Team = team4;
      result17.Team = team4;  
      result18.Team = team4;

      //Result -> Event

      result1.Event = event1;
      result2.Event = event2;
      result3.Event = event3;
      result4.Event = event7;
      result5.Event = event8;
      result6.Event = event9;
      result7.Event = event4;
      result8.Event = event5;
      result9.Event = event6;
      result10.Event = event4;
      result11.Event = event5;
      result12.Event = event6;
      result13.Event = event1;
      result14.Event = event2;
      result15.Event = event3;
      result16.Event = event7;
      result17.Event = event8;
      result18.Event = event9;
      result19.Event = event10; //trainingsmeeting
      result20.Event = event11; //trainingsmeeting

      //Result -> Student
      result19.Student = student11; //trainingsmeeting
      result20.Student = student11; //trainingsmeeting
      
      #endregion
      #region Advertisement

      //Advertisement -> Continent
      advertisement1.Continents.Add(continent);

      //Advertisement -> Country
      advertisement2.Countries.Add(country1);

      //Advertisement -> Sport
      advertisement1.Sports.Add(athletiek);
      advertisement2.Sports.Add(swimming);

      #endregion

      /*
       * ==========================================
       * Saving to context
       * ==========================================
       */

      #region ISF

      context.ISFs.Add(isf);

      #endregion
      #region Sport

      context.Sports.Add(athletiek);
      context.Sports.Add(swimming);

      #endregion
      #region Discipline

      context.Disciplines.Add(discipline1);
      context.Disciplines.Add(discipline2);
      context.Disciplines.Add(discipline3);
      context.Disciplines.Add(discipline4);
      context.Disciplines.Add(discipline5);
      context.Disciplines.Add(discipline6);

      #endregion
      #region Record


      context.Records.Add(record);

      #endregion
      #region Continent


      context.Continents.Add(continent);

      #endregion
      #region Country


      context.Countries.Add(country1);
      context.Countries.Add(country2);

      #endregion
      #region Region


      context.Regions.Add(region1);
      context.Regions.Add(region2);
      context.Regions.Add(region3);
      context.Regions.Add(region4);
      context.Regions.Add(region5);

      #endregion
      #region Location

      context.Locations.Add(location1);
      context.Locations.Add(location2);
      context.Locations.Add(location3);
      context.Locations.Add(location4);
      context.Locations.Add(location5);
      context.Locations.Add(location6);
      context.Locations.Add(location7);
      context.Locations.Add(location8);
      context.Locations.Add(location9);
      context.Locations.Add(location10);
      context.Locations.Add(location11);
      context.Locations.Add(location12);
      context.Locations.Add(location13);
      context.Locations.Add(location14);
      context.Locations.Add(location15);
      context.Locations.Add(location16);
      context.Locations.Add(location17);
      context.Locations.Add(location18);
      context.Locations.Add(location19);
      context.Locations.Add(location20);
      context.Locations.Add(location21);
      context.Locations.Add(location22);
      context.Locations.Add(location23);
      context.Locations.Add(location24);
      context.Locations.Add(location25);
      context.Locations.Add(location26);
      context.Locations.Add(location27);
      context.Locations.Add(location28);
      context.Locations.Add(location29);

      #endregion
      #region Advertisement


      context.Advertisements.Add(advertisement1);
      context.Advertisements.Add(advertisement2);

      #endregion
      #region Representative


      context.Representatives.Add(representative1);
      context.Representatives.Add(representative2);

      #endregion
      #region NSF


      context.NSFs.Add(nsf1);
      context.NSFs.Add(nsf2);

      #endregion
      #region School


      context.Schools.Add(school1);
      context.Schools.Add(school2);

      #endregion
      #region Coordinatior


      context.CoachCoordinators.Add(coordinator1);
      context.CoachCoordinators.Add(coordinator2);

      #endregion
      #region Coach


      context.CoachCoordinators.Add(coach1);
      context.CoachCoordinators.Add(coach2);
      context.CoachCoordinators.Add(coach3);
      context.CoachCoordinators.Add(coach4);

      #endregion
      #region Team

      context.Teams.Add(team1);
      context.Teams.Add(team2);
      context.Teams.Add(team3);
      context.Teams.Add(team4);

      #endregion
      #region Student

      context.Students.Add(student11);
      context.Students.Add(student12);
      context.Students.Add(student13);
      context.Students.Add(student14);

      context.Students.Add(student21);
      context.Students.Add(student22);
      context.Students.Add(student23);
      context.Students.Add(student24);

      context.Students.Add(student31);
      context.Students.Add(student32);
      context.Students.Add(student33);
      context.Students.Add(student34);

      context.Students.Add(student41);
      context.Students.Add(student42);
      context.Students.Add(student43);
      context.Students.Add(student44);

      #endregion
      #region Subscription


      context.Subscriptions.Add(subscription1);
      context.Subscriptions.Add(subscription2);
      context.Subscriptions.Add(subscription3);
      context.Subscriptions.Add(subscription4);
      context.Subscriptions.Add(subscription5);
      context.Subscriptions.Add(subscription6);

      #endregion
      #region Meeting


      context.Meetings.Add(meeting1);
      context.Meetings.Add(meeting2);
      context.Meetings.Add(meeting3);
      context.Meetings.Add(meeting4); //trainingsmeeting

      #endregion
      #region Event


      context.Events.Add(event1);
      context.Events.Add(event2);
      context.Events.Add(event3);
      context.Events.Add(event4);
      context.Events.Add(event5);
      context.Events.Add(event6);
      context.Events.Add(event7);
      context.Events.Add(event8);
      context.Events.Add(event9);
      context.Events.Add(event10);  //trainingsmeeting
      context.Events.Add(event11);  //trainingsmeeting

      #endregion
      #region Result


      context.Results.Add(result1);
      context.Results.Add(result2);
      context.Results.Add(result3);
      context.Results.Add(result4);
      context.Results.Add(result5);
      context.Results.Add(result6);
      context.Results.Add(result7);
      context.Results.Add(result8);
      context.Results.Add(result9);
      context.Results.Add(result10);
      context.Results.Add(result11);
      context.Results.Add(result12);
      context.Results.Add(result13);
      context.Results.Add(result14);
      context.Results.Add(result15);
      context.Results.Add(result16);
      context.Results.Add(result17);
      context.Results.Add(result18);
      context.Results.Add(result19);  //trainingsmeeting
      context.Results.Add(result20);  //trainingsmeeting

      #endregion


      /*
       * =========================
       * Saving of the initializer
       * =========================
       */

      #region SaveChanges
      context.SaveChanges();
      #endregion
    }
  }
}