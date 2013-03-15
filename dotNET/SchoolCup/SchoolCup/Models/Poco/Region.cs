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

    public List<Meeting> Meetings { get; set; }
    public List<School> Schools { get; set; }
    public int CountryId { get; set; }
    public Country Country { get; set; }
  }
}