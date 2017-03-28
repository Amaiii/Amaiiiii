using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class Campus
    {
        #region PropertiesRegion

        public string Name { get; private set; }

        public List<Course> Courses { get; set; }

        #endregion

        #region Constructor Region

        public Campus(string name)
        {
            this.Name = name;
            Courses = new List<Course>();
        }

        #endregion
    }
}

