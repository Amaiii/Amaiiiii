using Projekt.Models;
using System.Collections.Generic;

namespace Projekt
{
    public class DataGenerator
    {
        public static School GetSchool()
        {
            var abcaCampus = new Campus("abca");
            var dabcaCampus = new Campus("dabca");

            var programmingCourse = new Course("Programowanie", null, abcaCampus);
            var networkCourse = new Course("Sieciowy", null, dabcaCampus);
            var sandwichCourse = new Course("Sandwich", null, null);

            var programmingUnits = new List<Unit>()
            {
                new Unit("Nauka programowania w c#", programmingCourse),
                new Unit("Data bazy", programmingCourse),
                new Unit("Teoria", programmingCourse),
                new Unit("Projekt", programmingCourse)
            };

            programmingCourse.Units = programmingUnits;

            var networkUnits = new List<Unit>
            {
                new Unit("Networking", networkCourse),
                new Unit("Teoria", networkCourse),
                new Unit("Wsparcie systemu komputerowego", networkCourse),
                new Unit("Projekt", networkCourse),
            };

            networkCourse.Units = networkUnits;

            var sandwichUnits = new List<Unit>
            {
                new Unit("Networking", sandwichCourse),
                new Unit("Teoria", sandwichCourse),
                new Unit("Wsparcie systemu komputerowego", sandwichCourse),
                new Unit("Projekt", sandwichCourse),
                new Unit("Work Placement", sandwichCourse)
            };

            abcaCampus.Courses.Add(programmingCourse);
            dabcaCampus.Courses.Add(networkCourse);


            var school = new School();
            school.Campuses = new List<Campus>(2) { abcaCampus, dabcaCampus };

            var students = new List<Student>()
            {
                new Student(1, "test1", "test1", 2015, new System.DateTime(1995, 10, 10), programmingCourse),
                new Student(2, "test2", "test2", 2015, new System.DateTime(1994, 11, 11), programmingCourse),
                new Student(3, "test3", "test3", 2015, new System.DateTime(1993, 12, 12), programmingCourse),
                new Student(4, "test4", "test4", 2016, new System.DateTime(1995, 9, 9), programmingCourse),
                new Student(5, "test5", "test5", 2016, new System.DateTime(1995, 8, 8), programmingCourse),
                new Student(6, "test6", "test6", 2015, new System.DateTime(1995, 1, 1), networkCourse),
                new Student(7, "test7", "test7", 2015, new System.DateTime(1994, 2, 2), networkCourse),
                new Student(8, "test8", "test8", 2015, new System.DateTime(1993, 3, 3), networkCourse),
                new Student(9, "test9", "test9", 2016, new System.DateTime(1995, 4, 4), networkCourse),
                new Student(10, "test10", "test10", 2016, new System.DateTime(1995, 5, 5), networkCourse)
            };

            school.Students = students;

            return school;
        }
    }
}
