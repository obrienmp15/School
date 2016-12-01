using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace School.DataClients.Models
{
  [DataContract]
  public class ScheduleDAO
  {
    [DataMember]
    public int ScheduleId { get; set; }

    [DataMember]
    public CourseDAO Course { get; set; }

    [DataMember]
    public  ClassDateDAO ClassDate { get; set; }

    [DataMember]
    public string Name { get; set; }
  }
}