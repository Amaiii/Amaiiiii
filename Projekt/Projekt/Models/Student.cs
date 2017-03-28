using System;
using System.Collections.Generic;
using System.Linq;

namespace Projekt.Models
{
    public class Student
    {

        #region Properties Region

        public int StudentID { get; private set; }

        public string Forename { get; private set; }

        public string Surname { get; private set; }

        public int StartYear { get; private set; }

        public DateTime BornDate { get; private set; }

        public Course Course { get; set; }

        public Dictionary<Unit, int> PassedUnits { get; set; }
        
        #endregion

        #region Constructor Region

        public Student(int studentID, string forename, string surname, int startYear, DateTime bornDate, Course course)
        {
            StudentID = studentID;
            Forename = forename;
            Surname = surname;
            StartYear = startYear;
            BornDate = bornDate;
            PassedUnits = new Dictionary<Unit, int>();
            Course = course;
        }

        #endregion

        #region Method Region

        //Checks if the student had birthday this year.
        private bool HadBirthdayThisYear()
        {
            DateTime today = DateTime.Today;
            DateTime thisYearsBirthday = new DateTime(today.Year, BornDate.Month, BornDate.Day);

            TimeSpan timeSpan = today.Subtract(thisYearsBirthday);

            int daysToBirthday = timeSpan.Days;

            if (daysToBirthday < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //Gets Student age in Years.
        public int Age()
        {
            DateTime today = DateTime.Today;

            int age = today.Year - BornDate.Year;

            if (!HadBirthdayThisYear())
            {
                age -= 1;
            }

            return age;
        }

        public string DisplayDOB()
        {
            return BornDate.ToString("dd/MM/yyyy");
        }

        public int GetTotalPoints()
        {
            return PassedUnits != null && PassedUnits.Any() ? PassedUnits.Sum(pu => pu.Value) : 0;
        }

        #endregion
    }
}
