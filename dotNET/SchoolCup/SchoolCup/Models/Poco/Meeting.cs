using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolCup.Models.POCO
{
  public class Meeting
  {
    public int MeetingId { get; set; }
    public String Name { get; set; }
    public DateTime Date { get; set; }
    public String AlbumURL { get; set; }

    public int RegionId { get; set; }
    public virtual Region Region { get; set; }
    public int LocationId { get; set; }
    public virtual Location Location { get; set; }
    public int StudentId { get; set; }
    public virtual Student Student { get; set; }
    public virtual List<Subscription> Subscriptions { get; set; }
    public virtual List<Event> Events { get; set; }
  }
}