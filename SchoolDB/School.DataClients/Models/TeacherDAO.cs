using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace School.DataClients.Models
{
  [DataContract]
  public class TeacherDAO
  {
    [DataMember]
    public int TeacherId { get; set; }
    [DataMember]
    public CourseDAO Course { get; set; }
    [DataMember]
    public ScheduleDAO Schedule { get; set; }
    [DataMember]
    public string FirstName { get; set; }
    [DataMember]
    public string LastName { get; set; }
  }
}