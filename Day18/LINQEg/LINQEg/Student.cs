using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace LINQEg
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public float Marks { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }

        public Student()
        {

        }
        public Student(int sid, string sname, float marks, DateTime doj, string city)
        {
            StudentID = sid;
            StudentName = sname;
            Marks = marks;
            DOJ = doj;
            City = city;
        }

        public override string ToString()
        {
            return string.Format(StudentID + "---" + StudentName + "---" + Marks + "  " + DOJ + "  " +  City);
        }


    }
}
