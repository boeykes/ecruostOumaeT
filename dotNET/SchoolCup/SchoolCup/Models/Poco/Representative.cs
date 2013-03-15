using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolCup.Models.POCO
{
  public class Representative
  {
    public int RepresentativeId { get; set; }
    public String Name { get; set; }
    public String Email { get; set; }
    public String Function { get; set; }
  }
}