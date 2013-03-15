using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolCup.Models.POCO
{
  public class Region
  {
    public int RegionId { get; set; }
    public String Name { get; set; }

    public virtual List<Meeting> Meetings { get; set; }
    public virtual List<School> Schools { get; set; }
    public int CountryId { get; set; }
    public virtual Country Country { get; set; }
  }
}