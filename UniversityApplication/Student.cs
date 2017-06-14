using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApplication
{
    class Student:Person
    {
        public Student() { }
        public Student(string fname,string lname, string staddress, string city, 
            string state, string telephone,string sid)
        {
            this.studentID = sid;
        }

        private string studentID;
        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }


    }
}
