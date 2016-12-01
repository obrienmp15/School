using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace School.DataClients.Models
{
  [DataContract]
  public class MajorDAO
  {
    [DataMember]
    public int MajorId { get; set; }

    [DataMember]
    public string Name { get; set; }
  }
}