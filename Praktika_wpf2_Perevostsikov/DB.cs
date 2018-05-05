using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_wpf2_Perevostsikov
{
    class DB
    {
        static Context c = new Context();
        

        public static List<Camp> GetAllCamp()
        {
            return c.Camps.ToList() ;
        }

        public static List<Camp> GetAllCampByCampName(string campName)
        {
            return c.Camps.Where(a=>a.CampName.ToLower().StartsWith(campName.ToLower())).ToList();
        }


        public static List<Group> GetAllGroupsByCampId(int campId)
        {
            return c.Groups.Where(a => a.Camp.ID == campId).OrderBy(a=>a.ID).ToList();
        }


        public static List<Group> GetAllGroups()
        {
            return c.Groups.ToList();
        }




        public static Group GetGroupByGroupId(int groupId)
        {
            return c.Groups.Where(a => a.ID == groupId).First();
        }

        public static List<Student> GetAllStudentsByGroupId(int groupId)
        {
            return c.Students.Where(a=>a.Group.ID== groupId).ToList();
        }


        public static List<Student> GetAllStudents()
        {
            return c.Students.OrderByDescending(a=>a.LastName).ToList();
        }

        public static Student GetStudentByStudentId(int studentId)
        {
            return c.Students.Where(a => a.ID==studentId).First();
        }


        public static List<Student> GetAllStudentByStudentLastName(string lastName, int groupId)
        {
            return c.Students.Where(a => a.LastName.ToLower().StartsWith(lastName.ToLower()) && a.Group.ID== groupId).ToList();
        }


        public static List<Group> GetAllGroupsByGroupName(string groupName, int campId)
        {
            return c.Groups.Where(a => a.GroupName.ToLower().StartsWith(groupName.ToLower()) && a.Camp.ID == campId).ToList();
        }




        public static Camp GetCampByCampId(int campId)
        {
            return c.Camps.Where(a => a.ID==campId).First();
        }


        public static int updateCamp(Camp camp)
        {
            int arv = 0;
            //foreach (var i in c.Students)
            //{
            //    if (i.Camp.ID == camp.ID)
            //    {
            //        i.Camp = camp;
            //    }
            //}
            var original = c.Camps.Find(camp.ID);
            c.Entry(original).CurrentValues.SetValues(camp);
            arv = 1;
            return arv;
        }




        public static int updateStudent(Student student)
        {
            int arv = 0;
            var original = c.Students.Find(student.ID);
            c.Entry(original).CurrentValues.SetValues(student);

            arv = 1;
            return arv;
        }


        public static int updateGroup(Group group)
        {
            int arv = 0;
            var original = c.Groups.Find(group.ID);
            c.Entry(original).CurrentValues.SetValues(group);

            arv = 1;
            return arv;
        }




        public static int addCamp(Camp camp)
        {
            int arv = 0;
            c.Camps.Add(camp);
            arv = 1;
            return arv;
        }




        public static int addStudent(Student student)
        {
            int arv = 0;
            c.Students.Add(student);
            arv = 1;
            return arv;
        }


        public static int addGroup(Group group)
        {
            int arv = 0;
            c.Groups.Add(group);
            arv = 1;
            return arv;
        }




        public static int deleteCamp(Camp camp)
        {
            int arv = 0;
            c.Camps.Remove(camp);
            arv = 1;
            return arv;
        }


        public static int deleteStudent(Student student)
        {
            int arv = 0;
            c.Students.Remove(student);
            arv = 1;
            return arv;
        }

        public static int deleteGroup(Group group)
        {
            int arv = 0;
            c.Groups.Remove(group);
            arv = 1;
            return arv;
        }






        public static void Save()
        {
            c.SaveChanges();
        }


    }
}
