namespace ApiWebApplication.Migrations
{
    using ApiWebApplication.DataAccess;
    using ApiWebApplication.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApiWebApplication.DataAccess.SchoolDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled =true;
            AutomaticMigrationDataLossAllowed = true;            
        }

        protected override void Seed(ApiWebApplication.DataAccess.SchoolDbContext context)
        {           
            List<Course> courses = new List<Course>
            {
               new Course { Code="001",Name="Primero" , Amount=20,Id=1},
               new Course { Code="002", Name="Segundo",Amount =20 ,Id=2 },
               new Course { Code="003",Name="Tercero",Amount =20,Id=3 },
               new Course { Code="004",Name ="Cuarto",Amount=20,Id=4 },
               new Course { Code="005",Name ="Quinto",Amount =20,Id =5}
            };
            courses.ForEach(s => context.Courses.AddOrUpdate(p => p.Code , s));
            List<IdentificationType> identificationTypes = new List<IdentificationType> 
            {
                new IdentificationType { Id =1 ,Name="Cedula de ciudadania"},
                new IdentificationType {Id =2 ,Name ="Tarjete de identidad"},
                new IdentificationType {Id =3,Name="Registro civil"},
                new IdentificationType {Id =4 ,Name ="Pasaporte"},
                new IdentificationType {Id =5 ,Name ="Cedula de extranjeria"}
            };
            identificationTypes .ForEach(t=>context.IdentificationTypes .AddOrUpdate(p=> p.Name , t));
            List<Sex> sexes = new List<Sex> {
                new Sex { Id =1,Name ="Masculino"},
                new Sex {Id =2,Name ="Femenino"},
            };
            sexes.ForEach(s => context.Sexes.AddOrUpdate(p => p.Name, s));
            List<Status> statuses = new List<Status>
            {
                 new Status { Id =1 ,Name ="Nuevo" },
                 new Status { Id =2 ,Name ="Suspendido" },
                 new Status {Id =3 ,Name ="Cancelado" },
                 new Status {Id =4 ,Name ="Reprobado" },
                 new Status {Id =4 ,Name ="Aprobado" },

            };
            statuses.ForEach(ss => context.Statuses.AddOrUpdate(p => p.Name, ss));
            context .SaveChanges();
        }
    }
}
