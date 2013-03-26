using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolCup.Models.POCO
{
  public class School
  {
    public int SchoolId { get; set; }
    public String Name { get; set; }
    public String Phone { get; set; }
    public String EMail { get; set; }
    public String WebsiteURL { get; set; }

    public int LocationId { get; set; }
    public virtual Location Location { get; set; }
    public int NSFId { get; set; }
    public virtual NSF NSF { get; set; }
    public int RegionId { get; set; }
    public virtual Region Region { get; set; }
    public virtual List<Student> Students { get; set; }
    public virtual List<Team> Teams { get; set; }
    public int? CoachCoordinatorId { get; set; }                           //voor coordinator
    public virtual CoachCoordinator CoachCoordinator { get; set; }                //voor coach
    public virtual List<CoachCoordinator> CoachCoordinators { get; set; }
  }
}