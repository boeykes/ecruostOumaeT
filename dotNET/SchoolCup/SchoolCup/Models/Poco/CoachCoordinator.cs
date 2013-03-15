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
    public String Phone { get; set; }
    public String Mobile { get; set; }
    public String EMail { get; set; }

    public int LocationId { get; set; }
    public Location Location { get; set; }
    public int SchoolId { get; set; }
    public School School { get; set; }
    public List<School> Schools { get; set; }
    public List<Team> Teams { get; set; }
  }
}