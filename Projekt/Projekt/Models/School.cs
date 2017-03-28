using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class School
    {
        public IEnumerable<Campus> Campuses { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
}
