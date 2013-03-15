using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolCup.Models.POCO
{
  public class Sport
  {
    public int SportId { get; set; }
    public String Type { get; set; }

    public List<Discipline> Disciplines { get; set; }
    public List<Team> Teams { get; set; }
  }
}