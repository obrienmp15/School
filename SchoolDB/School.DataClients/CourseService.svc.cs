using School.DataAccess;
using School.DataClients.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace School.DataClients
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CourseService" in code, svc and config file together.
  // NOTE: In order to launch WCF Test Client for testing this service, please select CourseService.svc or CourseService.svc.cs at the Solution Explorer and start debugging.
  public class CourseService : ICourseService
  {
    
    private EfData ef = new EfData();

    public void DoWork()
    {
      throw new NotImplementedException();
    }

    public List<CourseDAO> GetCourses()
    {
      var g = new List<CourseDAO>();

      foreach (var course in ef.GetCourses())
      {
        g.Add(CourseAutoMapper.MapToCourseDAO(course));
      }

      return g;
    }

    public List<MajorDAO> GetMajors()
    {
      throw new NotImplementedException();
    }

    public List<StudentDAO> GetStudents()
    {
      throw new NotImplementedException();
    }

    public bool InsertCourse(CourseDAO course)
    {
      var c = new Course();

      c.CourseName = course.Name;
      c.Capacity = course.Capacity;
      c.Credit = course.Credit;
            

      return ef.InsertCourse(c);
    }


  }
}
