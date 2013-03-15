using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolCup.Models.POCO
{
  public class Subscription
  {
    public int SubscriptionId { get; set; }
    public DateTime Date { get; set; }

    public int TeamId { get; set; }
    public Team Team { get; set; }
    public int MeetingId { get; set; }
    public Meeting Meeting { get; set; }
  }
}