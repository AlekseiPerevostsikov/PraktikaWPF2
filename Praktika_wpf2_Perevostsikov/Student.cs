using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_wpf2_Perevostsikov
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Isikukood { get; set; }
        public string SchoolName { get; set; }
        public string ClassNumber { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public int CampId { get; set; }

        public Student()
        {

        }
        //s

        public virtual Camp Camp { get; set; }
    }
}
