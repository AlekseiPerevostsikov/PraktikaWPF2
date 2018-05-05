using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_wpf2_Perevostsikov
{
    public class Group
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int CampId { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }

        public virtual Camp Camp { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
