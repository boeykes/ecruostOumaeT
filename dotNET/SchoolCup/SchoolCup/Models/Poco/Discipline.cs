using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolCup.Models.Poco
{
  public class Discipline
  {
    public String Name { get; set; }
    public Boolean IsTime { get; set; }
    public Double MinTimeDistance { get; set; }
    public Double MaxTimeDistance { get; set; }
  }
}