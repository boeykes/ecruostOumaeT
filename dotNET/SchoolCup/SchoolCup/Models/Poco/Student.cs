using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolCup.Models.Poco
{
  public class Student
  {
    public String Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Char Gender { get; set; }
    public String PhotoURL { get; set; }
    public String Phone { get; set; }
    public String Mobile { get; set; }
    public String EMail { get; set; }
  }
}