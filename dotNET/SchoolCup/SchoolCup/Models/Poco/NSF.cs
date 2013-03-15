using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolCup.Models.POCO
{
  public class NSF
  {
    public int NSFId { get; set; }
    public String Name { get; set; }
    public int PhoneNumber { get; set; }
    public int FaxNumber { get; set; }
    public int YearOfMembership { get; set; }

    public int RepresentativeId { get; set; }
    public Representative Representative { get; set; }
    public int LocationId { get; set; }
    public Location Location { get; set; }
    public List<Region> Regions { get; set; }
    public List<School> Schools { get; set; }
  }
}