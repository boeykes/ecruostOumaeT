using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolCup.Models.POCO
{
  public class Student
  {
    public int StudentId { get; set; }
    public String Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Char Gender { get; set; }
    public String PhotoURL { get; set; }
    public String Phone { get; set; }
    public String Mobile { get; set; }
    public String EMail { get; set; }

    public int LocationId { get; set; }
    public Location Location { get; set; }
    public int SchoolId { get; set; }
    public School School { get; set; }
    public List<Team> Teams { get; set; }
    public List<Result> Results { get; set; }
    public List<Meeting> Meetings { get; set; }
  }
}