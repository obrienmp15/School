using AutoMapper;
using School.DataAccess;
using School.DataClients.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School.DataClients
{
  public class StudentAutoMapper
  {
    private MapperConfiguration mapper =
      new MapperConfiguration(m => m.CreateMap<Student, StudentDAO>().ForMember(d => d.StudentId, o => o.MapFrom(s => s.StudentId)));

    public object MapTo(object o, object o1)
    {
      var m = mapper.CreateMapper();

      return m.Map(o, o1);
    }
  }
}