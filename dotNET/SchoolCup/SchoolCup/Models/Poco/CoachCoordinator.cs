using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolCup.Models.POCO
{
  public class CoachCoordinator
  {
    public int CoachCoordinatorId { get; set; }
    public String Name { get; set; }
    public Boolean isCoordinator { get; set; }
    public String Phone { get; set; }
    public String Mobile { get; set; }
    public String EMail { get; set; }

    public int? LocationId { get; set; }
    public virtual Location Location { get; set; }
    public virtual List<School> Schools { get; set; }
    public virtual List<Team> Teams { get; set; }
  }
}