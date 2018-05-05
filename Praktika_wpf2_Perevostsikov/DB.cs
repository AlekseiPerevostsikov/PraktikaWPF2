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
            return c.Groups.Where(a => a.Camp.ID == campId).ToList();
        }


        public static List<Student> GetAllStudentsByGroupId(int groupId)
        {
            return c.Students.Where(a=>a.Group.ID== groupId).ToList();
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

        public static int addCamp(Camp camp)
        {
            int arv = 0;

            c.Camps.Add(camp);

            arv = 1;
            return arv;
        }


        public static int deleteCamp(Camp camp)
        {
            int arv = 0;

            //c.Camps.Find(camp.ID);
            c.Camps.Remove(camp);

            arv = 1;
            return arv;
            
        }

        public static void Save()
        {
            c.SaveChanges();
        }


    }
}
