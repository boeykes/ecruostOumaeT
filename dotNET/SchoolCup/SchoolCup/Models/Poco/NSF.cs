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
    public String PhoneNumber { get; set; }
    public String FaxNumber { get; set; }
    public int YearOfMembership { get; set; }

    public int RepresentativeId { get; set; }
    public virtual Representative Representative { get; set; }
    public int LocationId { get; set; }
    public virtual Location Location { get; set; }
    public virtual List<Region> Regions { get; set; }
    public virtual List<School> Schools { get; set; }
  }
}