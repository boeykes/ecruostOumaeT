using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolCup.Models.POCO
{
  public class Country
  {
    public int CountryId { get; set; }
    public String Name { get; set; }

    public List<Region> Regions { get; set; }
    public int ContinentId { get; set; }
    public Continent Continent { get; set; }
  }
}