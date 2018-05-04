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

    }
}
