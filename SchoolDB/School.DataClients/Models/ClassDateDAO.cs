using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace School.DataClients.Models
{
  [DataContract]
  public class ClassDateDAO
  {
    [DataMember]
    public int ClassDateId { get; set; }

    [DataMember]
    public TimeSpan ClassTime { get; set; }

    [DataMember]
    public string ClassDay { get; set; }
  }
}