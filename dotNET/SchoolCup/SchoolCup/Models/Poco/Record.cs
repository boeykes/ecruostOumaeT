using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolCup.Models.Poco
{
  public class Record
  {
    public String Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Char Gender { get; set; }
    public DateTime DateObtained { get; set; }
    public Double TimeDistance { get; set; }
    public String Kind { get; set; }
  }
}