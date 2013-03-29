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

    public int? DisciplineId { get; set; }
    public virtual Discipline Discipline { get; set; }
    public virtual List<Result> Results { get; set; }
  }
}