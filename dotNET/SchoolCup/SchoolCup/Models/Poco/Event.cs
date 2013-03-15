using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolCup.Models.POCO
{
  public class Event
  {
    public int EventId { get; set; }
    public Boolean SchoolCupEvent { get; set; }

    public int DisciplineId { get; set; }
    public Discipline Discipline { get; set; }
    public List<Result> Results { get; set; }
  }
}