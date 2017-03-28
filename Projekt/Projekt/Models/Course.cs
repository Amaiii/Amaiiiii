using System;
using System.Collections.Generic;
using System.Linq;

namespace Projekt.Models
{
    public class Course
    {
        #region Properties Region

        public IEnumerable<Unit> Units { get; set; }

        public Campus Campus { get; private set; }

        public string Name { get; private set; }

        #endregion

        #region Constructor Region

        public Course(string courseName, IEnumerable<Unit> units, Campus campus)
        {
            Name = courseName;
            Campus = campus;
            
            if (units != null && units.Any() && units.Count() >= 6)
            {
                throw new Exception("Ilość unitów przekroczona");
            }

            Units = units;
        }

        #endregion
    }
}

