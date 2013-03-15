using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolCup.Models.POCO
{
  public class Discipline
  {
    public int DisciplineId { get; set; }
    public String Name { get; set; }
    public Boolean IsTime { get; set; }
    public Double MinTimeDistance { get; set; }
    public Double MaxTimeDistance { get; set; }

    public int SportId { get; set; }
    public Sport Sport { get; set; }   
  }
}