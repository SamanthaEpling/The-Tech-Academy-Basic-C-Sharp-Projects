using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int CourseID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [Range(0, 5)]
        public int Credits { get; set; }

        public int DepartmentID { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace ContosoUniversity.Models
//{
//    public class Course
//    {
//        [DatabaseGenerated(DatabaseGeneratedOption.None)] //Allows us to enter PK rather than DB generated.
//        public int CourseID { get; set; }
//        public string Title { get; set; }
//        public int Credits { get; set; }

//        public virtual ICollection<Enrollment> Enrollments { get; set; }// Enrollments property is a navigation property.
//                                                                        // A course entity (ONE) can be related to (MANY) Enrollment entities.
//    }
//}