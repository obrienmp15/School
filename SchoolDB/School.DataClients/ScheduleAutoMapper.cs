using AutoMapper;
using School.DataAccess;
using School.DataClients.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School.DataClients
{
  public class ScheduleAutoMapper
  {
    private MapperConfiguration mapper =
      new MapperConfiguration(m => m.CreateMap<Schedule, ScheduleDAO>().ForMember(d => d.ScheduleId, o => o.MapFrom(s => s.ScheduleId)));

    public object MapTo(object o, object o1)
    {
      var m = mapper.CreateMapper();

      return m.Map(o, o1);
    }
  }
}