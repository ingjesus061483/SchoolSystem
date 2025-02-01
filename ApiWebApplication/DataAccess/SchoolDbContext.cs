using ApiWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Hierarchy;
using System.Linq;
using System.Web;

namespace ApiWebApplication.DataAccess
{
    public class SchoolDbContext:DbContext
    {
        public SchoolDbContext():base(ConfigurationManager.ConnectionStrings["SchoolSystem"].ConnectionString )
        { 
           
        }
        public DbSet<Relationship> Relationships { get; set; }
        public DbSet <Attendant> Attenants { get; set; }
        public  DbSet<Course> Courses { get; set; }
        public DbSet<SchoolSubject> SchoolSubjects { get; set; }
        public DbSet <CourseSubject> CourseSubjects { get; set; }
        public DbSet<IdentificationType > IdentificationTypes { get; set; }
        public DbSet< Sex> Sexes { get; set; }
        public DbSet <Student > Students { get; set; }
        public DbSet <Status > Statuses { get; set; }
        public DbSet <Picture> Pictures { get; set; }
        public DbSet <PicturePerson >PicturePeople { get; set; }
        public DbSet <WorkingDay > WorkingDays { get; set; }
        public DbSet <Tuition> Tuitions { get; set; }
        public DbSet<Strangeness> Strangenesses {  get; set; }
        public DbSet <Concept> Concepts { get; set; }   
    }
}