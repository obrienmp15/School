using AutoMapper;
using School.DataAccess;
using School.DataClients.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School.DataClients
{
  public class CourseAutoMapper
  {
    private MapperConfiguration mapper =
      new MapperConfiguration(m => m.CreateMap<Course, CourseDAO>().ForMember(d => d.CourseId, o => o.MapFrom(s => s.CourseId)));

    public object MapToCourseDAO(object o, object o1)
    {
      var m = mapper.CreateMapper();

      return m.Map(o, o1);
    }

    internal static CourseDAO MapToCourseDAO(Course course)
    {
      throw new NotImplementedException();
    }
  }
}