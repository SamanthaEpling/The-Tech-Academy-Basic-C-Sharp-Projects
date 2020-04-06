using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace ContosoUniversity.Models
//{
    
//    public enum Grade
//    {
//        A, B, C, D, F
//    }
//    public class Enrollment
//    {
//        public int EnrollmentID { get; set; }
//        public int CourseID { get; set; }
//        public int StudentID { get; set; } //FOREIGN KEY, CORRESPONDING TO NAVIGATION PROPERTY: Course
//                                            // An (MANY)Enrollment entity is associated with ONE Course entity.
//        public Grade? Grade { get; set; }

//        public virtual Course Course { get; set; }
//        public virtual Student Student { get; set; }
//    }

//    // Entity Framework interprets a property as a foreign key property if it's named 
//    // <navigation property name> <primary key property name> 
//    // ex: FK: StudentID, as it is the PK for the Student enitity
//    // ex: FK CourseID, as it is the PK for the Course entity
//}