using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApplication
{
    class Course
    {
        public Course() { }
        private string courseNum;
        public string CourseNum
        {
            get { return courseNum; }
            set { courseNum = value; }
        }

        private string courseName;
        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        private int creditHours;
        public int CreditHours
        {
            get { return creditHours; }
            set { creditHours = value; }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private int departmentID;
        public int DepartmentID
        {
            get { return departmentID; }
            set { departmentID = value; }
        }
    }
}
