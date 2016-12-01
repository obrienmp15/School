using SchoolDB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DataAccess
{
  public class EfData
  {
    private SchoolDBEntities db = new SchoolDBEntities();

    /// <summary>
    /// Lists
    /// </summary>
    /// <returns></returns>
    public List<Course> GetCourses()
    {
      return db.Courses.ToList();
    }
    public List<ClassDate> GetClassDates()
    {
      return db.ClassDates.ToList();
    }
    public List<Department> GetDepartments()
    {
      return db.Departments.ToList();
    }
    public List<Major> GetMajors()
    {
      return db.Majors.ToList();
    }
    public List<Schedule> GetSchedules()
    {
      return db.Schedules.ToList();
    }
    public List<Student> GetStudents()
    {
      return db.Students.ToList();
    }
    public List<Teacher> GetTeachers()
    {
      return db.Teachers.ToList();
    }

    /// <summary>
    ///  Inserts
    /// </summary>
    /// <returns></returns>
    public bool InsertCourse(Course course)
    {
      db.Courses.Add(course);
      return db.SaveChanges() > 0;
    }
    public bool InsertClassDate(ClassDate classdate)
    {
      db.ClassDates.Add(classdate);
      return db.SaveChanges() > 0;
    }
    public bool InsertDepartment(Department department)
    {
      db.Departments.Add(department);
      return db.SaveChanges() > 0;
    }
    public bool InsertMajor(Major major)
    {
      db.Majors.Add(major);
      return db.SaveChanges() > 0;
    }
    public bool InsertSchedule(Schedule schedule)
    {
      db.Schedules.Add(schedule);
      return db.SaveChanges() > 0;
    }
    public bool InsertStudent(Student student)
    {
      db.Students.Add(student);
      return db.SaveChanges() > 0;
    }
    public bool InsertTeacher(Teacher teacher)
    {
      db.Teachers.Add(teacher);
      return db.SaveChanges() > 0;
    }

    /// <summary>
    /// Changes
    /// </summary>
    public bool ChangeCourse(Course course, EntityState state)
    {
      var entry = db.Entry<Course>(course);

      entry.State = state;
      return db.SaveChanges() > 0;
    }
    public bool ChangeClassDate(ClassDate classdate, EntityState state)
    {
      var entry = db.Entry<ClassDate>(classdate);

      entry.State = state;
      return db.SaveChanges() > 0;
    }
    public bool ChangeDepartment(Department department, EntityState state)
    {
      var entry = db.Entry<Department>(department);

      entry.State = state;
      return db.SaveChanges() > 0;
    }
    public bool ChangeMajor(Major major, EntityState state)
    {
      var entry = db.Entry<Major>(major);

      entry.State = state;
      return db.SaveChanges() > 0;
    }
    public bool ChangeSchedule(Schedule schedule, EntityState state)
    {
      var entry = db.Entry<Schedule>(schedule);

      entry.State = state;
      return db.SaveChanges() > 0;
    }
    public bool ChangeStudent(Student student, EntityState state)
    {
      var entry = db.Entry<Student>(student);

      entry.State = state;
      return db.SaveChanges() > 0;
    }
    public bool ChangeTeacher(Teacher teacher, EntityState state)
    {
      var entry = db.Entry<Teacher>(teacher);

      entry.State = state;
      return db.SaveChanges() > 0;
    }
    

    public void SearchCourse()
    {
      var actives = db.Courses.Where(a => a.Active);
      var inactives = db.Courses.Where(a => !a.Active);
      var ma = db.Courses.Where(m => m.CourseName.ToLower().Contains("al"));

    }


  }
}

