//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace School.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Teacher
    {
        public int TeacherId { get; set; }
        public int CourseId { get; set; }
        public int ScheduleId { get; set; }
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public bool Active { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Schedule Schedule { get; set; }
    }
}