using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class Unit
    {
        #region Properties Region

        public string Name { get; set; }

        public int Points { get; set; }

        public Course Course { get; set; }

        #endregion

        #region Constructor Region

        public Unit(string name, Course course, int points = 6)
        {
            this.Name = name;
            this.Course = course;
            this.Points = points;
        }

        #endregion
    }
}

