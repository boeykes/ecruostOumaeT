using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolCup.Models.POCO
{
  public class Continent
  {
    public int ContinentId { get; set; }
    public String Name { get; set; }

    public List<Country> Countries { get; set; }
  }
}