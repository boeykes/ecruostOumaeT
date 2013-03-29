using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolCup.Models.POCO
{
  public class ISF
  {
    public int ISFId { get; set; }
    public String PhoneNumber { get; set; }
    public String FaxNumber { get; set; }
    public String EMail { get; set; }

    public virtual List<Advertisement> Advertisements { get; set; }
    public virtual List<NSF> NFSs { get; set; }
    public virtual List<Record> Records { get; set; }
    public int? LocationId { get; set; }
    public virtual Location Location { get; set; }
  }
}