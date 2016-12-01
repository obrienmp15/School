using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace School.DataClients.Models
{
  [DataContract]
  public class StudentDAO
  {
    [DataMember]
    public int StudentId { get; set; }
    [DataMember]
    public string FirstName { get; set; }
    [DataMember]
    public string LastName { get; set; }
    [DataMember]
    public MajorDAO Major { get; set; }
    [DataMember]
    public ScheduleDAO Schedule { get; set; }
  }
}