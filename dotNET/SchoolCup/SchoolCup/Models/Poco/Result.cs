using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolCup.Models.POCO
{
  public class Result
  {
    public int ResultId { get; set; }
    public Double TimeDistance { get; set; }
    public Int32 Points { get; set; }

    public int StudentId { get; set; }
    public Student Student { get; set; }
    public int TeamId { get; set; }
    public Team Team { get; set; }
    public int EventId { get; set; }
    public Event Event { get; set; }
  }
}