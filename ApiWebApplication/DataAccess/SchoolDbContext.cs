using ApiWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Web;

namespace ApiWebApplication.DataAccess
{
    public class SchoolDbContext:DbContext
    {
        public SchoolDbContext():base(ConfigurationManager.ConnectionStrings["SchoolSystem"].ConnectionString )
        { 
        }
       public  DbSet<Course> Courses { get; set; }
        public DbSet<SchoolSubject> SchoolSubjects { get; set; }
        public DbSet <CourseSubject> CourseSubjects { get; set; }
        public DbSet<IdentificationType > IdentificationTypes { get; set; }
        public DbSet< Sex> Sexes { get; set; }
        public DbSet <Student > Students { get; set; }
    }
}