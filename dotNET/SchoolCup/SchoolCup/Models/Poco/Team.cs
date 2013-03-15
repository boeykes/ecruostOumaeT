using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolCup.Models.POCO
{
  public class Team
  {
    public int TeamId { get; set; }
    public String Name { get; set; }
    public String PhotoURL { get; set; }
    public String LogoURL { get; set; }

    public int SchoolId { get; set; }
    public virtual School School { get; set; }
    public int CoachCoordinatorId { get; set; }
    public virtual CoachCoordinator CoachCoordinator { get; set; }
    public virtual List<Student> Students { get; set; }
    public virtual List<Subscription> Subscriptions { get; set; }
    public virtual List<Result> Results { get; set; }
    public int SportId { get; set; }
    public virtual Sport Sport { get; set; }
  }
}