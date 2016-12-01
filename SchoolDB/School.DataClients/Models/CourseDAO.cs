using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace School.DataClients.Models
{
  [DataContract]
  public class CourseDAO
  {
    [DataMember]
    public int CourseId { get; set; }

    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public TeacherDAO Teacher { get; set; }

    [DataMember]
    public int Capacity { get; set; }

    [DataMember]
    public int Credit { get; set; }

    [DataMember]
    public StudentDAO Enrollment { get; set; }

    [DataMember]
    public  DepartmentDAO Department { get; set; }

    [DataMember]
    public  ScheduleDAO Schedule { get; set; }
    

  }
}
