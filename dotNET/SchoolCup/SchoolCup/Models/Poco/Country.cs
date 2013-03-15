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

    public virtual List<Region> Regions { get; set; }
    public int ContinentId { get; set; }
    public virtual Continent Continent { get; set; }
  }
}