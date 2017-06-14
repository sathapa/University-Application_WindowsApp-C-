using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApplication
{
    class CoursesOffered
    {
        public CoursesOffered() { }
        private string semester;
        public string Semester
        {
            get { return semester; }
            set { semester = value; }
        }

        private int maxEnrollment;
        public int MaxEnrollment
        {
            get { return maxEnrollment; }
            set { maxEnrollment = value; }
        }

        private int enrolledCount;
        public int EnrolledCount
        {
            get { return enrolledCount; }
            set { enrolledCount = value; }
        }

        private string roomNumber;
        public string RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }
        
    }
}
