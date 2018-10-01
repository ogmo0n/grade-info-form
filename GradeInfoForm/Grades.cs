using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeInfoForm {
    public class Grades {

        //private string lastName;
        //private string firstName;
        //private int studentID;
        //private int classNum;
        //private string grade;

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int StudentID { get; set; }
        public string ClassName { get; set; }
        public string Grade { get; set; }

        public Grades() : this(string.Empty, string.Empty, 0, string.Empty, string.Empty) { }

        public Grades(string lname, string fname, int id, string cname, string grade) {
            this.LastName = lname;
            this.FirstName = fname;
            this.StudentID = id;
            this.ClassName = cname;
            this.Grade = grade;
        }

        public override string ToString() {
            return $"{LastName}, {FirstName}:\t {StudentID}\t{ClassName}\t\t {Grade}\n";
        }
    }
}
