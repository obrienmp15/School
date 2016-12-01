using School.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace School.Tests
{
  public class EfDataTests
  {
    [Fact]
    public void Test_GetCourses()
    {
      var data = new EfData();
      var actual = data.GetCourses();

      Assert.NotNull(actual);
    }
    [Fact]
    public void Test_GetClassDates()
    {
      var data = new EfData();
      var actual = data.GetClassDates();

      Assert.NotNull(actual);
    }
    [Fact]
    public void Test_GetDepartments()
    {
      var data = new EfData();
      var actual = data.GetDepartments();

      Assert.NotNull(actual);
    }
    [Fact]
    public void Test_GetMajors()
    {
      var data = new EfData();
      var actual = data.GetMajors();

      Assert.NotNull(actual);
    }
    [Fact]
    public void Test_GetSchedules()
    {
      var data = new EfData();
      var actual = data.GetSchedules();

      Assert.NotNull(actual);
    }
    [Fact]
    public void Test_GetStudents()
    {
      var data = new EfData();
      var actual = data.GetStudents();

      Assert.NotNull(actual);
    }
    [Fact]
    public void Test_GetTeachers()
    {
      var data = new EfData();
      var actual = data.GetTeachers();

      Assert.NotNull(actual);
    }

    [Fact]
    public void Test_InsertCourse()
    {
      var data = new EfData();
      var expected = new Course() { CourseName = "Algerbra", Active = true };

      var actual = data.ChangeCourse(expected, System.Data.Entity.EntityState.Added);

      Assert.True(actual);
    }
  }
}
