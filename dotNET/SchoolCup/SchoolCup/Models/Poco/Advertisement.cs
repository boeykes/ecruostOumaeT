using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolCup.Models.POCO
{
  public class Advertisement
  {
    public int AdvertisementId { get; set; }
    public String Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public String LogoURL { get; set; }

    public int ISFId { get; set; }
    public ISF ISF { get; set; }
    public List<Continent> Continents { get; set; }
    public List<Country> Countries { get; set; }
    public List<Sport> Sports { get; set; }
  }
}