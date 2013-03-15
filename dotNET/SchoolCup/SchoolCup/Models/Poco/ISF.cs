using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolCup.Models.POCO
{
  public class ISF
  {
    public int ISFId { get; set; }
    public int PhoneNumber { get; set; }

    public List<Advertisement> Advertisements { get; set; }
    public List<NSF> NFSs { get; set; }
    public List<Record> Records { get; set; }
    public int LocationId { get; set; }
    public Location Location { get; set; }
  }
}