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

    public virtual List<Discipline> Disciplines { get; set; }
    public virtual List<Team> Teams { get; set; }
  }
}