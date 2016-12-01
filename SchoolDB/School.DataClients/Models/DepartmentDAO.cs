﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace School.DataClients.Models
{
  [DataContract]
  public class DepartmentDAO
  {
    [DataMember]
    public int DepartmentId { get; set; }

    [DataMember]
    public string Name { get; set; }
  }
}