using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_wpf2_Perevostsikov
{
    class DataInitializer : DropCreateDatabaseAlways<Context>
    {

        protected override void Seed(Context context)
        {
            base.Seed(context);


            var camp = new List<Camp>
            {
                new Camp{CampName="Adler", Description="Adler - first camp in Estomia"},
                new Camp{CampName="Puma", Description="Puma camp"},
                new Camp{CampName="Paikese", Description="Paikese camp"},
                new Camp{CampName="OldSchool", Description="Very old camp"},
            };

            camp.ForEach(a => context.Camps.Add(a));
            context.SaveChanges();





            var student = new List<Student>
            {
                new Student{FirstName="Anton", LastName="Petrov", Isikukood="32345678911", SchoolName="Adber", ClassNumber="6B", Phone="+37213569874", Adress="Pushkino tee 14,Narva, Estonia", CampId=1},
                new Student{FirstName="Jana", LastName="Sidorova", Isikukood="42547895101", SchoolName="Astangu", ClassNumber="5A", Phone="+37245879264", Adress="Sillamae, Estonia", CampId=1},
                new Student{FirstName="Artem", LastName="Pavlov", Isikukood="39874521254", SchoolName="Vana", ClassNumber="7C", Phone="+37254587952", Adress="Sillamae, Estonia", CampId=1},
                new Student{FirstName="Alina", LastName="Tamm", Isikukood="49875124589", SchoolName="Kask", ClassNumber="1A", Phone="", Adress="Tallinn", CampId=2},
                new Student{FirstName="Pavel", LastName="Petrov", Isikukood="31547895214", SchoolName="Astangu", ClassNumber="9A", Phone="+37254789584", Adress="Narva", CampId=2},
                new Student{FirstName="Pavel", LastName="Sokolovskiy", Isikukood="34578485912", SchoolName="Kask", ClassNumber="7B", Phone="+37245128745", Adress="", CampId=1},
                new Student{FirstName="Olga", LastName="Panamarjova", Isikukood="48795321458", SchoolName="Piirn", ClassNumber="4C", Phone="", Adress="Tallinn", CampId=1},
                new Student{FirstName="Aleksandr", LastName="Smirnov", Isikukood="34578952147", SchoolName="Vana", ClassNumber="1A", Phone="", Adress="Narva", CampId=3},
                new Student{FirstName="Petr", LastName="Petrov", Isikukood="34578412015", SchoolName="Adber", ClassNumber="1A", Phone="", Adress="Narva", CampId=1},
            };

            student.ForEach(a => context.Students.Add(a));
            context.SaveChanges();
        }

    }
}
