﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ContosoUniversity.Models;

namespace ContosoUniversity.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
                new Student{FirstMidName="LionelE",LastName="Canine",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="RomaniE",LastName="Equine",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Mr. BubblesE",LastName="Feline",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="HermioneE",LastName="Feline",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="RosieE",LastName="Feline",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="MisterE",LastName="Feline",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstMidName="FionaE",LastName="Feline",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Love BugE",LastName="Feline",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var courses = new List<Course>
            {
            new Course{CourseID=1050,Title="Biology",Credits=3,},
            new Course{CourseID=4022,Title="Chemistry",Credits=3,},
            new Course{CourseID=4041,Title="Environmental Science",Credits=3,},
            new Course{CourseID=1045,Title="Calculus",Credits=4,},
            new Course{CourseID=3141,Title="Anatomy and Physiology",Credits=4,},
            new Course{CourseID=2021,Title="Microbiology",Credits=3,},
            new Course{CourseID=2042,Title="Dentistry",Credits=4,}
            };

            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050,},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };

            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }

    // SEED METHOD: takes the database context object as an INPUT PARAMETER, 
    //              then code in the method uses that object to add new entities to the database.
    //              For each entity type the code creates a collection of new entities, then 
    //              adds them to the corresponding DbSet property, saves changes to the Db.
}