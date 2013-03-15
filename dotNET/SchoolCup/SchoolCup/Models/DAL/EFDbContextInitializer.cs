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
      //Student student1 = new Student{Gender = 'm',Name = "Thomas"};
      context.SaveChanges();
     }
  }
}