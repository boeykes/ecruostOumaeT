using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

using System.Data.Entity.ModelConfiguration.Conventions;

namespace SchoolCup.Models.DAL
{
  public class EFDbContext : DbContext 
  {

    public GTDContext():base("Kdg_Schoolcup_Version01")
    {}




          protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    }
  }
}