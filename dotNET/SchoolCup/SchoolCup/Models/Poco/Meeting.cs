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
    public Region Region { get; set; }
    public int LocationId { get; set; }
    public Location Location { get; set; }
    public int StudentId { get; set; }
    public Student Student { get; set; }
    public List<Subscription> Subscriptions { get; set; }
    public List<Event> Events { get; set; }
  }
}